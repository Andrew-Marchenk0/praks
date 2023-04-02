namespace four
{
    interface IShare
    {
        void Draw(int size);
    }
    class VertlLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("|");
            }
        }
    }
    class HorizlLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("__");
            }
        }
    }
    class Sqre : IShare
    {
        public void Draw(int size)
        {
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
     class Consl
    {
        static void Main(string[] args)
        {
            List<IShare> shapes = new List<IShare>();
            shapes.Add(new VertlLine());
            shapes.Add(new HorizlLine());
            shapes.Add(new Sqre());
            foreach (IShare figure in shapes)
            {
                figure.Draw(20);
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}