
Param([string]$elevatedPath)

 $fileExists = Test-Path $elevatedPath

    if ($fileExists -eq $False) 
    {
        New-Item -ItemType Directory -Path $elevatedPath

        Copy-Item ..\WpfElevatedApp\WpfElevatedApp.exe $elevatedPath

    }

Set-Location $elevatedPath

.\WpfElevatedApp.exe

