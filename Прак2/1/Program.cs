sqrtcalc koren = new sqrtcalc();
void sqrtExpression(int a, int b, int c)
{
    koren.setDiscr(a, b, c);
    koren.setSqrt1(a, b, c);
    koren.setSqrt2(a, b, c);
}
sqrtExpression(23, 22, -61);
Console.WriteLine("Дискриминант  " + koren.getDiscr());
if (koren.getSqrt1() == -999999999 && koren.getSqrt2() == -999999999)
{
    Console.WriteLine("Корней нет");
}
else if (koren.getSqrt1() == -999999999 || koren.getSqrt2() == -999999999)
{
    if (koren.getSqrt1() == -999999999)
    {
        Console.WriteLine("Первый корень - корня нет");
    }
    else
    {
        Console.WriteLine("Второй корень -  Корня нет");
    }
}
else
{
    Console.WriteLine("Первый корень  " + koren.getSqrt1());
    Console.WriteLine("Второй корень  " + koren.getSqrt2());
}
Console.ReadKey();
class sqrtcalc
{
    private double sqrt1, sqrt2, discr;

    public double getSqrt1()
    {
        return sqrt1;
    }
    public double getSqrt2()
    {
        return sqrt2;
    }
    public double getDiscr()
    {
        return discr;
    }
    public void setSqrt1(int a, int b, int c)
    {
        this.sqrt1 = CalculateRoots(a, b, getDiscr())[0];
    }
    public void setSqrt2(int a, int b, int c)
    {
        this.sqrt2 = CalculateRoots(a, b, getDiscr())[1];
    }
    public void setDiscr(int a, int b, int c)
    {
        this.discr = (b * b) - 4 * a * c;
    }
    private double[] CalculateRoots(int a, int b, double d)
    {
        if (d > 0)
        {
            double sqrt1 = (-b + Math.Sqrt(d)) / (2 * a);
            double sqrt2 = (-b - Math.Sqrt(d)) / (2 * a);
            double[] sqrts = { sqrt1, sqrt2 };
            return sqrts;
        }
        else if (d == 0)
        {
            double sqrt1 = (-b + Math.Sqrt(d)) / (2 * a);
            double[] sqrts = { sqrt1, -999999999 };
            return sqrts;
        }
        else
        {
            double[] sqrts = { -999999999, -999999999 };
            return sqrts;
        }
    }
}
