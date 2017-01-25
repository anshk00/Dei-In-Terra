namespace DeiInTerra
{
    internal abstract class Item
    {
        public string sourceFile { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public int damage { get; set; }
        public int range { get; set; }
        public int availability { get; set; }
        public int armorRating { get; set; }
        public int manaCost { get; set; }
        public int attackSpeed { get; set; }
        public int stealthRating { get; set; }

        public int levelRequirement
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}