namespace task_1_4_6;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        Console.Write("n = ");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Stepen(n)
            ? "Введенное число n является степенью 2"
            : "Введенное число n не является степенью 2");
    }

    static bool Stepen(double n)
    {
        if (n <= 0)
        {
            return false;
        }
        else if (n > 1)
        {
            while (n > 1)
            {
                if (n % 2 != 0)
                {
                    return false;
                }

                n /= 2;
            }

            return true;
        }
        else
        {
            while (n < 1)
            {
                n *= 2;
            }

            return n == 1;
        }
    }
}
    
    
        
            