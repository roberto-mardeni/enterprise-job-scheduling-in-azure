# Input bindings are passed in via param block.
param($Timer)

$ErrorActionPreference = 'Stop'

# Get the current universal time in the default string format
$currentUTCtime = (Get-Date).ToUniversalTime()

# The 'IsPastDue' porperty is 'true' when the current function invocation is later than scheduled.
if ($Timer.IsPastDue) {
    Write-Host "PowerShell timer is running late!"
}

# Write an information log with the current time.
Write-Host "PowerShell timer trigger function ran! TIME: $currentUTCtime"

Set-Location "D:\Home\site\wwwroot\TimerTrigger1"

.\ConsoleApp.exe