$PluginId = "ReSharperPlugin.SilkDotNet"
$SolutionPath = "$PSScriptRoot\ReSharperPlugin.SilkDotNet.sln"
$SourceBasePath = "$PSScriptRoot\src\dotnet"

$VsWhereOutput = [xml] (& "$PSScriptRoot\tools\vswhere.exe" -format xml -latest -products *)
$VisualStudio = $VsWhereOutput.instances.instance |
    Where-Object { $_.channelId -match "Release" } |
    Sort-Object -Property installationVersion |
    Select-Object -Last 1

$VisualStudioBaseDirectory = $VisualStudio.installationPath
$VisualStudioMajorVersion = ($VisualStudio.installationVersion -split '\.')[0]
$VisualStudioInstanceId = $VisualStudio.instanceId
$DevEnvPath = Get-ChildItem "$VisualStudioBaseDirectory\*\IDE\devenv.exe"
$MSBuildPath = Get-ChildItem "$VisualStudioBaseDirectory\MSBuild\*\Bin\MSBuild.exe"

$OutputDirectory = "$PSScriptRoot\output"
$NuGetPath = "$PSScriptRoot\tools\nuget.exe"

Function Invoke-Exe {
    param(
        [parameter(mandatory=$true,position=0)] [ValidateNotNullOrEmpty()] [string] $Executable,
        [Parameter(ValueFromRemainingArguments=$true)][String[]] $Arguments,
        [parameter(mandatory=$false)] [array] $ValidExitCodes = @(0)
    )

    Write-Host "> $Executable $Arguments"
    $rc = Start-Process -FilePath $Executable -ArgumentList $Arguments -NoNewWindow -Passthru
    $rc.Handle # to initialize handle according to https://stackoverflow.com/a/23797762/2684760
    $rc.WaitForExit()
    if (-Not $ValidExitCodes.Contains($rc.ExitCode)) {
        throw "'$Executable $Arguments' failed with exit code $($rc.ExitCode), valid exit codes: $ValidExitCodes"
    }
}
