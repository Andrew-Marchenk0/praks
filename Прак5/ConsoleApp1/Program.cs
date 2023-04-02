namespace first
{
    interface IAnimal
    {
        void Voice();
    }
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав!");
        }
    }
    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }
    class Owl : IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тише, я спю!");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }
    class fox : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("фрфрфрф");
        }
    }
    class MinPig : IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }

        public void Voice()
        {
            int currentTime = GetCurrentTime();
            if ((currentTime >= 0) && (currentTime <= 9))
            {
                Console.WriteLine("Свинья официально(не по слухам) в загоне, и конечно спит");
            }
            else
            {
                Console.WriteLine("Бекон уже пахнэ...");
            }
        }
    }
     class animalTouch
    {
        static void PetAnimal(IAnimal animal)
        {
            Console.WriteLine("Я официально чухнул бродягу, и он мне говорит:");
            animal.Voice();
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();
            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new fox());
            myAnimals.Add(new MinPig());
            foreach (IAnimal animal in myAnimals)
            {
                PetAnimal(animal);
            }
            Console.ReadKey(true);
        }
    }
}