namespace tripl
{
    interface IFilter
    {
        string Except(string txtlineup);
    }
    class FilterZnak : IFilter
    {
        public string Except(string txtlineup)
        {
            string stroke = "";
            char[] symb = { ' ', ',', ':', ';', '-', '"', '(', ')', '.', '!', '?', '_', '`' };
            for (int i = 0; i < txtlineup.Length; i++)
            {
                if (char.IsLetter(txtlineup[i]) || Array.IndexOf(symb, txtlineup[i]) >= 0)
                {
                    stroke += txtlineup[i];
                }
            }
            return stroke;
        }
    }
    class LetterFilter : IFilter
    {
        public string Except(string textline)
        {
            string stroke = "";
            for (int i = 0; i < textline.Length; i++)
            {
                if (char.IsDigit(textline[i]))
                {
                    stroke += textline[i];
                }
            }
            return stroke;
        }
    }
     class textSimb
    {
        static void Main(string[] args)
        {
            FilterZnak stringLetters = new FilterZnak();
            Console.WriteLine(stringLetters.Except("Волки и ночью воют"));
            LetterFilter stringDigits = new LetterFilter();
            Console.WriteLine(stringDigits.Except("К1нам2начемп3приехал4антизрист5нацист6и7ничего8не9написал."));
            Console.ReadKey(true);
        }
    }
}
