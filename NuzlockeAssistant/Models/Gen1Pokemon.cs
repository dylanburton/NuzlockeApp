using System.ComponentModel.DataAnnotations;

namespace NuzlockeAssistant.Models
{
    public class Gen1Pokemon
    {
        [Key]
        public string Number { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Special { get; set; }
        public int Speed { get; set; }
    }
}
