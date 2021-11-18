namespace Dotnet6EFCore.Model
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int Age { get; set; }
        public virtual Heart Heart { get; set; }
    }
}