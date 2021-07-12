Param(
    $RootSuffix = "SilkDotNet",
    $Version = "9999.0.0"
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"
$PSScriptRoot = Split-Path $MyInvocation.MyCommand.Path -Parent
Set-Location $PSScriptRoot

. ".\settings.ps1"

$UserProjectXmlFile = "$SourceBasePath\$PluginId\$PluginId.csproj.user"

if (!(Test-Path "$UserProjectXmlFile")) {
    # Get versions from Plugin.props file
    $PluginPropsFile = "$SourceBasePath\Plugin.props"
    $PluginPropsXml = [xml] (Get-Content "$PluginPropsFile")
    $SdkVersionNode = $PluginPropsXml.SelectSingleNode(".//SdkVersion")
    $VersionSplit = $SdkVersionNode.InnerText.Split(".")
    $MajorVersion = "$($VersionSplit[0]).$($VersionSplit[1])"
    $MajorVersionShort = "$($MajorVersion[2])$($MajorVersion[3])$($MajorVersion[5])"

    # Determine download link
    $ReleaseUrl = "https://data.services.jetbrains.com/products/releases?code=RSU&type=eap&type=release&majorVersion=$MajorVersion"
    $VersionEntry = $(Invoke-WebRequest -UseBasicParsing $ReleaseUrl | ConvertFrom-Json).RSU[0]
    ## TODO: check versions
    $DownloadLink = [uri] $VersionEntry.downloads.windows.link

    # Download installer
    $InstallerFile = "$PSScriptRoot\build\installer\$($DownloadLink.Segments[-1])"
    if (!(Test-Path $InstallerFile)) {
        mkdir -Force $(Split-Path $InstallerFile -Parent) > $null
        Write-Output "Downloading $($DownloadLink.Segments[-2].TrimEnd("/")) installer"
        (New-Object System.Net.WebClient).DownloadFile($DownloadLink, $InstallerFile)
    } else {
        Write-Output "Using cached installer from $InstallerFile"
    }

    # Execute installer
    Write-Output "Installing experimental hive"
    Invoke-Exe $InstallerFile "/VsVersion=$VisualStudioMajorVersion.0" "/SpecificProductNames=ReSharper" "/Hive=$RootSuffix" "/Silent=True"

    $Installations = @(Get-ChildItem "$env:APPDATA\JetBrains\ReSharperPlatformVs$VisualStudioMajorVersion\v$($MajorVersionShort)_$VisualStudioInstanceId$RootSuffix\NuGet.Config")
    if ($Installations.Count -ne 1) { Write-Error "Found no or multiple installation directories: $Installations" }
    $InstallationDirectory = $Installations.Directory
    Write-Host "Found installation directory at $InstallationDirectory"

    # Adapt packages.config
    if (Test-Path "$InstallationDirectory\packages.config") {
        $PackagesXml = [xml] (Get-Content "$InstallationDirectory\packages.config")
    } else {
        $PackagesXml = [xml] ("<?xml version=`"1.0`" encoding=`"utf-8`"?><packages></packages>")
    }

    if ($null -eq $PackagesXml.SelectSingleNode(".//package[@id='$PluginId']/@id")) {
        $PluginNode = $PackagesXml.CreateElement('package')
        $PluginNode.setAttribute("id", "$PluginId")
        $PluginNode.setAttribute("version", "$Version")

        $PackagesNode = $PackagesXml.SelectSingleNode("//packages")
        $PackagesNode.AppendChild($PluginNode) > $null

        $PackagesXml.Save("$InstallationDirectory\packages.config")
    }

    # Adapt user project file
    $HostIdentifier = "$($InstallationDirectory.Parent.Name)_$($InstallationDirectory.Name.Split('_')[-1])"

    Set-Content -Path "$UserProjectXmlFile" -Value "<Project><PropertyGroup><HostFullIdentifier></HostFullIdentifier></PropertyGroup></Project>"

    $ProjectXml = [xml] (Get-Content "$UserProjectXmlFile")
    $HostIdentifierNode = $ProjectXml.SelectSingleNode(".//HostFullIdentifier")
    $HostIdentifierNode.InnerText = $HostIdentifier
    $ProjectXml.Save("$UserProjectXmlFile")

    # Install plugin
    $PluginRepository = "$env:LOCALAPPDATA\JetBrains\plugins"
    Remove-Item "$PluginRepository\${PluginId}.${Version}" -Recurse -ErrorAction Ignore
    Invoke-Exe $MSBuildPath "/t:Restore;Rebuild;Pack" "$SolutionPath" "/v:minimal" "/p:PackageVersion=$Version" "/p:PackageOutputPath=`"$OutputDirectory`""
    Invoke-Exe $NuGetPath install $PluginId -OutputDirectory "$PluginRepository" -Source "$OutputDirectory" -DependencyVersion Ignore

    Write-Output "Re-installing experimental hive"
    Invoke-Exe "$InstallerFile" "/VsVersion=$VisualStudioMajorVersion.0" "/SpecificProductNames=ReSharper" "/Hive=$RootSuffix" "/Silent=True"
} else {
    Write-Warning "Plugin is already installed. To trigger reinstall, delete $UserProjectXmlFile."
}

Invoke-Exe $MSBuildPath "/t:Restore;Rebuild" "$SolutionPath" "/v:minimal"
Invoke-Exe $DevEnvPath "/rootSuffix $RootSuffix" "/ReSharper.Internal" "/ReSharper.LogFile $PSScriptRoot\ReSharper.log" "/ReSharper.LogLevel Trace"
