open System

#I "packages/FSharp.Management/lib/net40"
#r "System.Management.Automation.dll"
#r "FSharp.Management.PowerShell.dll"

open FSharp.Management
type PS = PowerShellProvider< "Microsoft.PowerShell.Management;Microsoft.PowerShell.Core" >

let x = PS.``Write-Host`` "Hello, world!"
