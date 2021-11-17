$name = Read-Host -Prompt 'Input your db name default:Dotnet_EFCore_6'
if ([string]::IsNullOrWhiteSpace($name))
{
    $name = "Dotnet_EFCore_6"
}
$dbname = "" + $PWD + "\$name.mdf" #// 資料庫的名稱加位置
$query = "Create Database $name on primary (Name='$name',Filename='" + $dbname + "');" #// 建立資料庫的指令
Write-Output $query
Write-Output "Connect String : Server=(localdb)\\MSSQLLocalDB;Database=$name;Trusted_Connection=True;MultipleActiveResultSets=true"
sqlcmd -S '(LocalDb)\MSSQLLocalDB' -q $query #// 使用sqlcmd來創建資料庫