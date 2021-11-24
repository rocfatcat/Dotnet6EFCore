namespace Dotnet6EFCore.Model;

public class Meeting
{
    public int MeetingId { get; set; }
    public string MeetingName { get; set; } = string.Empty;

    public DateTime? StartDate { get; set; }
    public DateTime? ENDDate { get; set; }
}