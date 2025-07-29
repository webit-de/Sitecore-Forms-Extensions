$Origin = "C:\Users\uhlemann\projects\Sitecore-Forms-Extensions\downloads\Sitecore 10.3\Sitecore Forms Extensions for SC10.3-4.1.2.zip"
$Destination = "C:\Users\uhlemann\projects\Sitecore-Forms-Extensions\downloads\Sitecore 10.3\"

Import-Module "C:\tools\Sitecore Azure Toolkit 2.5.0-r02519.1061\tools\Sitecore.Cloud.Cmdlets.dll" -Verbose 
$wdpPath = ConvertTo-SCModuleWebDeployPackage -Path $Origin -Destination $Destination -Force