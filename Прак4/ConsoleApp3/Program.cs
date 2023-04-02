namespace tripl
{
    class Orc
    {
        private static int counter;
        public static int GoldAmount { get; private set; }
        public int OrcGold { get; private set; }
        public Orc()
        {
            counter++;
            GoldAmount += 2;
            if (counter > 5)
            {
                OrcGold -= 2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Orc FirstOrc_Volody = new Orc();
            Orc SecondOrc_Vycheslav = new Orc();
            Orc TriplOrc_Ivanchik = new Orc();
            Orc FourthOrc_Drake = new Orc();
            Orc FivthOrc_Maximus = new Orc();
            Console.WriteLine(Orc.GoldAmount);
            Orc SixthOrc_Danchus = new Orc();
            Orc SeventsOrc_Vladimus = new Orc();
            Orc EightOrc_Borisich = new Orc();
            Console.WriteLine(EightOrc_Borisich.OrcGold);
            Console.ReadKey(true);
        }
    }
}