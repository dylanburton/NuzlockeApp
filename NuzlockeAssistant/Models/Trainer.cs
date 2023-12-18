

using System.Diagnostics.CodeAnalysis;

namespace NuzlockeAssistant.Models
{

    public class Trainer
    {
        public int ID { get; set; }
        [AllowNull]
        public string Name { get; set; }
        [AllowNull]
        public List<Pokemon> Team { get; set; }
        [AllowNull]
        public List<Pokemon> Box { get; set; }
        [AllowNull]
        /*used mainly for encounter stats, moveset, etc.*/
        public Pokemon Encounter { get; set; }
        [AllowNull]
        public Pokemon DeathBox { get; set; }
        /*used to track major battles for level cap
         * TODO: Fill in when opportunity arrises.
         */
        /*public bool[] Progress  { get; set; }*/
        public int LevelCap { get; set; }
        public bool Alive { get; set; } = true;


    }


}

