namespace second
{
    class SendBox
    {
        public string Description { get; private set; }
        public int Weight { get; private set; }
        public SendBox(string description, int weight)
        {
        Description = description;
        Weight = weight;
        }
    }
    class Sending
    {
        private int a = 0;
        private const int Limit = 76;
        private static int i = 0;
        private static int WeightLim;
        public void SendPackage(SendBox box)
        {
            WeightLim += box.Weight;
            if (WeightLim >= Limit)
            {
            a++;
            Console.WriteLine(
            "Посылки слишком тяжелые, отправка всех посылок отменена.");
            }
            else
            {
            i++;
            Console.WriteLine("Посылка {0} весом {1} кг четко отправленна.",
            box.Description, box.Weight);
            
            }
        }
    }
    class post
    {
        static void Main(string[] args)
        {
            SendBox send_first = new SendBox("Первая коробка", 30);
            SendBox send_second = new SendBox("Вторая коробка", 30);
            SendBox send_tripl = new SendBox("Третья коробка", 230);
            Sending courer_senders = new Sending();
            courer_senders.SendPackage(send_first);
            courer_senders.SendPackage(send_second);
            courer_senders.SendPackage(send_tripl);

            Console.ReadKey();
        }
    }
}