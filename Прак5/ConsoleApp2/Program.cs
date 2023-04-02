namespace second
{
    interface IHello
    {
        void SayHello();
    }
    class Portugal : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Olá");
        }
    }
    class UK : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Ivrit : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("чет на еврейсом שלום");
        }
    }
    class KZ : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Сәлеметсіз бе");
        }
    }
    class taddjukiSTONE : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Салом");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new Portugal());
            greetings.Add(new UK());
            greetings.Add(new Ivrit());
            greetings.Add(new KZ());
            greetings.Add(new taddjukiSTONE());
            foreach (IHello hello in greetings)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}
