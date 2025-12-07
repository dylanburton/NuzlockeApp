using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace NuzlockeAssistant.Models
{
    public class Pokemon
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
        [AllowNull]
        public string Nickname { get; set; }
        public string Type1 { get; set; }
        [AllowNull]
        public string Type2 { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Special { get; set; }
        public int Speed { get; set; }
        public int Capture_Rate { get; set; }
        /*might prop here for evolution or setup another model to match db*/
        /*public Pokemon(string number, string name, string type1, string type2, int hP, int attack, int defense, int special, int speed, string location = "Starter")
        {
            Number = number;
            Name = name;
            Nickname = name;
            Type1 = type1;
            Type2 = type2;
            HP = hP;
            Attack = attack;
            Defense = defense;
            Special = special;
            Speed = speed;

        }*/
    }
}
