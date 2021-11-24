namespace Dotnet6EFCore.Model;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public DateTime? OnboardDate { get; set; }

    public Meeting? NowMeeting { get; set; }
}