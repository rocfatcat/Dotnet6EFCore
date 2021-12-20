$defaultName = (Get-Item -Path (Get-Location) |Select-Object BaseName).BaseName
$name = (Read-Host -Prompt "Input your drop db name default:$defaultName")
if ([string]::IsNullOrWhiteSpace($name))
{
    $name = $defaultName
}
$query = "drop Database $name" #// 刪除資料庫的指令
Write-Output $query
sqlcmd -S '(LocalDb)\MSSQLLocalDB' -q $query #//用sqlcmd來刪除資料庫