
namespace ProjetoDio_Rpg.Entities
{
    public class Heroes
    {
        private string Type;
        public int Level { get; set; }
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int MagicPoints { get; set; }

        public Heroes(int level, string name, int hp, int mp, string type)
        {
            Level = level;
            Name = name;
            HealthPoints = hp;
            MagicPoints = mp;
            Type = type;
        }
        public override string ToString()
        {
            return Name + "\n" + "Lv.  " + Level + "\t" + Type + "\n" + "Hp.  " + HealthPoints + "\n" + "Mp.  " + MagicPoints + "\n________________________________\n";
        }
    }
}
