if(($null -eq $TestName) -or ($TestName -contains 'Get-AzFirmwareAnalysisCve'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzFirmwareAnalysisCve.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzFirmwareAnalysisCve' {
    It 'List' {
        { 
            $config = Get-AzFirmwareAnalysisCve -FirmwareId '7795b9a8-97bb-ba4b-b21a-8dc6ae2dabb9' -ResourceGroupName 'FirmwareAnalysisRG' -WorkspaceName 'default'
            $config.Count | Should -BeGreaterThan 0
        } | Should -Not -Throw
    }
}
