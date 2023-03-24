class SMS
{
    private string SMStxt { get; set; }
    private double Price { get; set; }

    public SMS(string messageText)
    {
        SMStxt = messageText;
        Price = 0;
    }
    public void CalculatePrice()
    {
        if (SMStxt.Length <= 65)
        {
            Price = 1.5;
        }
        else
        {
            Price = (1.5 + (SMStxt.Length - 65) * 50) / 100;
        }
    }
    public override string ToString()
    {
        return $"Входящее сообщение! - {SMStxt}, цена - {Price} рублей";
    }
    public static void Main(string[] args)
    {
        SMS message = new SMS("С новым годом! С вас");
        message.CalculatePrice();
        Console.WriteLine(message);
    }
}