calc b = new calc();
b.predictNum();
while (true)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (b.setNum(input))
    {
        b.predictNum();
    }
    else
    {
        Console.WriteLine("Ошибка");
        break;
    }
}

class calc
{
    private int b = 0;
    public int getNum()
    {
        return b;
    }
    public void resetNum()
    {
        b = 0;
    }
    public bool setNum(int b)
    {
        if (this.b + 1 == b)
        {
            this.b = b;
            return true;
        }
        else
        {
            resetNum();
            return false;
        }
    }
    public void predictNum()
    {
        Console.WriteLine("Введите число " + (this.b + 1));
    }
}