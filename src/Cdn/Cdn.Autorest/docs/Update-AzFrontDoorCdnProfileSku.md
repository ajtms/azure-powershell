---
external help file:
Module Name: Az.Cdn
online version: https://learn.microsoft.com/powershell/module/az.cdn/update-azfrontdoorcdnprofilesku
schema: 2.0.0
---

# Update-AzFrontDoorCdnProfileSku

## SYNOPSIS
Upgrade a profile from Standard_AzureFrontDoor to Premium_AzureFrontDoor.

## SYNTAX

```
Update-AzFrontDoorCdnProfileSku -ProfileName <String> -ResourceGroupName <String>
 -ProfileUpgradeParameter <IProfileUpgradeParameters> [-SubscriptionId <String>] [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Upgrade a profile from Standard_AzureFrontDoor to Premium_AzureFrontDoor.

## EXAMPLES

### Example 1: When a profile not associated with WAF policy.
```powershell
$nullUpgradePara = @{}
Update-AzFrontDoorCdnProfileSku -ProfileName profileName -ResourceGroupName rgName -ProfileUpgradeParameter $nullUpgradePara
```

```output
Location Name              Kind      ResourceGroupName
-------- ----              ----      -----------------
Global   profileName       frontdoor rgName
```

When a profile not associated with WAF policy.
Upgrade a profile from Standard_AzureFrontDoor to Premium_AzureFrontDoor.

### Example 2: When a CDN profile associated with WAF and copy to a new waf policy...
```powershell
$waf = New-AzFrontDoorCdnProfileChangeSkuWafMappingObject -SecurityPolicyName waf -ChangeToWafPolicyId /subscriptions/xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx/resourcegroups/rgName/providers/Microsoft.Network/frontdoorwebapplicationfirewallpolicies/newWAFName
$upgrade = New-AzFrontDoorCdnProfileUpgradeParametersObject -WafMappingList $waf

Update-AzFrontDoorCdnProfileSku -ProfileName profileName -ResourceGroupName rgName -ProfileUpgradeParameter $upgrade
```

```output
Location Name              Kind      ResourceGroupName
-------- ----              ----      -----------------
Global   profileName       frontdoor rgName
```

When a CDN profile associated with WAF and copy to a new WAF policy, the subscription and resource group of the new WAF policy should be same with the profile's.
Upgrade a profile from Standard_AzureFrontDoor to Premium_AzureFrontDoor.

### Example 2: When the CDN profile associated with WAF and select an exiting WAF policy..
```powershell
$waf1 = New-AzFrontDoorCdnProfileChangeSkuWafMappingObject -SecurityPolicyName waf1 -ChangeToWafPolicyId /subscriptions/xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx/resourcegroups/rgtest01/providers/Microsoft.Network/frontdoorwebapplicationfirewallpolicies/existingWAFName1
$waf2 = New-AzFrontDoorCdnProfileChangeSkuWafMappingObject -SecurityPolicyName waf2 -ChangeToWafPolicyId /subscriptions/xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx/resourcegroups/rgtest02/providers/Microsoft.Network/frontdoorwebapplicationfirewallpolicies/existingWAFName2
$upgrade = New-AzFrontDoorCdnProfileUpgradeParametersObject -WafMappingList @($waf1, $waf2)

Update-AzFrontDoorCdnProfileSku -ProfileName profileName -ResourceGroupName rgName -ProfileUpgradeParameter $upgrade
```

```output
Location Name              Kind      ResourceGroupName
-------- ----              ----      -----------------
Global   profileName       frontdoor rgName
```

When the CDN profile associated with WAF and select an existing WAF policy, you could only select the WAF policy located in the same subscription with the profile's.
Upgrade a profile from Standard_AzureFrontDoor to Premium_AzureFrontDoor.

### Example 4: A CDN profile associated with WAF, when the subscription of the profile is different from the local subscription
```powershell
$waf = New-AzFrontDoorCdnProfileChangeSkuWafMappingObject -SecurityPolicyName waf -ChangeToWafPolicyId /subscriptions/testSubId01/resourcegroups/rgtest01/providers/Microsoft.Network/frontdoorwebapplicationfirewallpolicies/ExistingPremiumWAFName
$upgrade = New-AzFrontDoorCdnProfileUpgradeParametersObject -WafMappingList $waf

Update-AzFrontDoorCdnProfileSku -ProfileName profileName -ResourceGroupName rgName -ProfileUpgradeParameter $upgrade -SubscriptionId testSubId01
```

```output
Location Name              Kind      ResourceGroupName
-------- ----              ----      -----------------
Global   profileName       frontdoor rgName
```

A CDN profile associated with WAF, when the subscription of the profile is different from the local subscription.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfileName
Name of the Azure Front Door Standard or Azure Front Door Premium which is unique within the resource group.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfileUpgradeParameter
Parameters required for profile upgrade.
To construct, see NOTES section for PROFILEUPGRADEPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileUpgradeParameters
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
Name of the Resource group within the Azure subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Azure Subscription ID.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfileUpgradeParameters

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProfile

## NOTES

## RELATED LINKS

