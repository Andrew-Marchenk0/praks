using System.Runtime.Intrinsics.X86;
Car VAZ2107 = new Car(180);
Console.WriteLine("Скорость ВАЗ 2107 = " + VAZ2107.maxSpeed + " км/ч");
Car SZA = new Car(90);
Console.WriteLine("Скорость С-3А = " + SZA.maxSpeed + " км/ч");
Car VAZ2114 = new Car(173);
Console.WriteLine("Скорость ВАЗ 2114 = " + VAZ2114.maxSpeed + " км/ч");
Car VAZ2115 = new Car(168);
Console.WriteLine("Скорость ВАЗ 2115 = " + VAZ2115.maxSpeed + " км/ч");



if (VAZ2107.maxSpeed > SZA.maxSpeed)
{
    Console.WriteLine("ВАЗ 2107 - 1 место");
}

if (SZA.maxSpeed > VAZ2114.maxSpeed)
{
    Console.WriteLine("ВАЗ 2114 - 2 место");
}

if (VAZ2114.maxSpeed > VAZ2115.maxSpeed)
{
    Console.WriteLine("ВАЗ 2115 - 3 место" + "\n" + "С-3А - 4 место");
}


class Car
{
    public double maxSpeed;

    public Car(double maxSpeed)
    {
        this.maxSpeed = maxSpeed;
    }
}

