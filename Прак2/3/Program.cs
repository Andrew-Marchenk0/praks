class CezarUTF
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст для шифрования - ");
        string txt = Console.ReadLine();
        Console.WriteLine("Введите ключ - ");
        int key = Convert.ToInt32(Console.ReadLine());
        string encTxt = Encode(txt, key);
        Console.WriteLine("Зашифрованный текст - " + encTxt);
        Console.WriteLine("Расшифрованный текст - " + Decode(encTxt, key));
        Console.ReadLine();
    }
    static string Encode(string txt, int key)
    {
        string endTxt = "";
        for (int i = 0; i < txt.Length; i++)
        {
            endTxt += (char)(txt[i] + key);
        }
        return endTxt;
    }
    static string Decode(string txt, int key)
    {
        string decTxt = "";
        for (int i = 0; i < txt.Length; i++)
        {
            decTxt += (char)(txt[i] - key);
        }
        return decTxt;
    }
}
