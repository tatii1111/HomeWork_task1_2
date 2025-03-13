namespace task_1_4_7;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число n:");
        Console.Write("n = ");
        double n = Convert.ToDouble(Console.ReadLine());
        double s = Math.Abs(n);
        double m = s - (int)s;
        int i = 0;
        int logn = (int)Math.Log(s, 10) + 1;
        if (m > 0)
        {
            while (m % 1 != 0)
            {
                m *= 10;
                i++;
            }
        }

        int result = i + logn;
        Console.WriteLine("Количество цифр в n равно " + result);
        Console.WriteLine(i);
        Console.WriteLine(logn);
    }
}