using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace NuzlockeAssistant.Models
{
    public class Nuzlocke
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        [AllowNull]
        public int Generation { get; set; } = 1;
        public DateTime Creation_Date { get; set; } = DateTime.Now;
        [AllowNull]
        public DateTime Finishi_Date { get; set; }
        public int Badges { get; set; } = 0;
        public int Alive { get; set; } = 1;

    }
}
