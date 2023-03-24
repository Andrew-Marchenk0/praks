Random rand = new Random();
rand.GetIntFixedLength(8);
public static class Randomizer
{
    public static int GetIntFixedLength(this Random rand, int length)
    {
        length = length > 0 && length < 10 ? length : 1; 
        return rand.Next(Convert.ToInt32(Math.Pow(10, length - 1)),
        Convert.ToInt32(Math.Pow(10, length)));
    }
    static void Calc()
    {
        int a = 0;
        double summ;
        int median;
        int i, j, k;
        double[] avr;
        avr = new double[a];
        for (i = 1; i <= a / 2; i++)
        {
            median = a / i;
            for (j = 0; j <= median - 1; j++)
            {
                summ = 0;
                for (k = j * i; k < j * i + i; k++)
                {
                    summ += k;
                }
                avr[j] = summ / i;
            }
            summ = 0;
            for (j = 0; j < (median - 1); j++)
            {
                summ += Math.Pow((avr[j + 1] - avr[j]), 2);
            }
        }
    }
    public static double StandardDeviation(List<double> valueList)
    {
       double M = 0.0;
       double S = 0.0;
       int k = 1;
       foreach (double value in valueList)
            {
          double tmpM = M;
          M += (value - tmpM) / k;
          S += (value - tmpM) * (value - M);
          k++;
            }
            return Math.Sqrt(S / (k - 2));
    }
}