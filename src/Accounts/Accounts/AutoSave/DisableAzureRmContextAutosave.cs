﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.IO;
using System.Management.Automation;

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Profile.Common;
using Microsoft.Azure.Commands.ResourceManager.Common;

using Newtonsoft.Json;

namespace Microsoft.Azure.Commands.Profile.Context
{
    [Cmdlet("Disable", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "ContextAutosave", SupportsShouldProcess = true)]
    [OutputType(typeof(ContextAutosaveSettings))]
    public class DisableAzureRmContextAutosave : AzureContextModificationCmdlet
    {
        protected override bool RequireDefaultContext() { return false; }

        public override void ExecuteCmdlet()
        {
            if (MyInvocation.BoundParameters.ContainsKey(nameof(Scope)) && Scope == ContextModificationScope.Process)
            {
                ConfirmAction("Do not autosave the context in the current session", "Current session", () =>
                {
                    ModifyContext((profile, client) =>
                    {
                        ContextAutosaveSettings settings = null;
                        AzureSession.Modify((session) => DisableAutosave(session, false, out settings));
                        ResourceManagerProfileProvider.InitializeResourceManagerProfile(true);
                        AzureRmProfileProvider.Instance.Profile = profile;
                        WriteObject(settings);
                    });
                });
            }
            else
            {
                ConfirmAction("Never autosave the context for the current user", "Current user",
                    () =>
                    {
                        ModifyContext((profile, client) =>
                        {
                            ContextAutosaveSettings settings = null;
                            AzureSession.Modify((session) => DisableAutosave(session, true, out settings));
                            ResourceManagerProfileProvider.InitializeResourceManagerProfile(true);
                            AzureRmProfileProvider.Instance.Profile = profile;
                            WriteObject(settings);
                        });
                    });
            }
        }

        void DisableAutosave(IAzureSession session, bool writeAutoSaveFile, out ContextAutosaveSettings result)
        {
            result = ContextAutosaveSettings.FromAzureSession(session, ContextSaveMode.Process);

            FileUtilities.DataStore = session.DataStore;
            session.ARMContextSaveMode = ContextSaveMode.Process;

            if (AzureSession.Instance.TryGetComponent(
                    PowerShellTokenCacheProvider.PowerShellTokenCacheProviderKey,
                    out PowerShellTokenCacheProvider originalTokenCacheProvider))
            {
                if(originalTokenCacheProvider is SharedTokenCacheProvider)
                {
                    var token = originalTokenCacheProvider.ReadTokenData();
                    //must explicitly use type PowerShellTokenCacheProvider
                    PowerShellTokenCacheProvider cacheProvider = new InMemoryTokenCacheProvider(token);
                    AzureSession.Instance.RegisterComponent(PowerShellTokenCacheProvider.PowerShellTokenCacheProviderKey, () => cacheProvider, true);
                }
            }

            if(AzureSession.Instance.TryGetComponent(AuthenticatorBuilder.AuthenticatorBuilderKey, out IAuthenticatorBuilder builder))
            {
                builder.Reset();
            }

            if (AzureSession.Instance.TryGetComponent(AzKeyStore.Name, out AzKeyStore keystore))
            {
                keystore.DisableSyncToStorage();
            }

            if (writeAutoSaveFile)
            {
                FileUtilities.EnsureDirectoryExists(session.ProfileDirectory);
                string autoSavePath = Path.Combine(session.ProfileDirectory, ContextAutosaveSettings.AutoSaveSettingsFile);
                session.DataStore.WriteFile(autoSavePath, JsonConvert.SerializeObject(result));
            }
        }
    }
}
