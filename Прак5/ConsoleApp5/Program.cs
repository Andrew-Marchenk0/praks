namespace five
{
    interface ISpell
    {
        string Name
        {
            get;
            set;
        }
        int Mana
        {
            get;
            set;
        }
        void WriteInfo();
    }
    class Spells
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        private string Effect { get; set; }
        public Spells(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void Use()
        {
            Console.WriteLine(Effect);
        }
    }
    class Magic
    {
        public string Name { get; private set; }
        public int Mana { get; private set; }
        public Magic(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spells spells)
        {
            if (Mana >= spells.Mana)
            {
                Mana -= spells.Mana;
                Console.WriteLine("{0} заклинает!", Name);
                spells.Use();
            }
            else
            {
                int mana = spells.Mana - Mana;
                Console.WriteLine(
                    "Для использования заклинания {0} не хватает {1} единиц маны. Съешь мангусик!",
                    spells.Name, mana);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Spells ecspilyrmus = new Spells("Ecspilyrmus", 60, "Отталкивает!");
            Spells eczorchizm = new Spells("Экзорцизм", 40, "Изгнание дауна!");
            Spells huk = new Spells("Хукаю", 100, "Кидаю хук в крипа!");
            Magic Martirosyn = new Magic("Мартиросян", 120);
            Martirosyn.CastSpell(ecspilyrmus);
            Martirosyn.CastSpell(eczorchizm);
            Martirosyn.CastSpell(huk);
            Console.ReadKey();
        }
    }
}
