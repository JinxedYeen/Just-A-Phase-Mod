# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/P3R.JustAPhaseOutfitMod/*" -Force -Recurse
dotnet publish "./P3R.JustAPhaseOutfitMod.csproj" -c Release -o "$env:RELOADEDIIMODS/P3R.JustAPhaseOutfitMod" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location