$name = Read-Host -Prompt 'Input your db name default:Dotnet_EFCore_6'
if ([string]::IsNullOrWhiteSpace($name)) {
    $name = "Dotnet_EFCore_6"
}
$query = "drop Database $name" #// 建立資料庫的指令
Write-Output $query
sqlcmd -S '(LocalDb)\MSSQLLocalDB' -q $query #/