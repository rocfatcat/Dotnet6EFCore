using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet6EFCore.Model
{
    public class Heart
    {
        [ForeignKey(nameof(Human))]
        public int Id { get; set; }
        public int Heartbeat { get; set; }
        public int BolldPressure { get; set; }

        public Human Human { get; set; } = new();
    }
}