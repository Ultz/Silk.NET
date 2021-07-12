Param(
    [string]$Configuration = "Release",
    [Parameter(Mandatory=$true)]
    [string]$Version,
    [Parameter(Mandatory=$true)]
    [string]$ApiKey
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"
$PSScriptRoot = Split-Path $MyInvocation.MyCommand.Path -Parent
Set-Location $PSScriptRoot

. ".\settings.ps1"

$ChangelogText = ([Regex]::Matches([System.IO.File]::ReadAllText("CHANGELOG.md"), '(?s)(##.+?.+?)(?=##|$)').Captures | Select -First 10) -Join ''

Invoke-Exe $MSBuildPath "/t:Restore;Rebuild;Pack" "$SolutionPath" "/v:minimal" "/p:Configuration=$Configuration" "/p:PackageOutputPath=$OutputDirectory" "/p:PackageVersion=$Version" "/p:PackageReleaseNotes=`"$ChangelogText`""
$PackageFile = "$OutputDirectory\$PluginId.$Version*.nupkg"
Invoke-Exe $NuGetPath push $PackageFile -Source "https://plugins.jetbrains.com/api/v2/package" -ApiKey $ApiKey
