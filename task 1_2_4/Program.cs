using System.Diagnostics; 

namespace task_1_2_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите три разных числа:");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        if ((a == b) || (b == c) || (c == a))
        {
            Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            Environment.Exit(0);
        }
        else if ((a > b) && (b > c))
            Console.WriteLine(b);
        else if ((a > c) && (c > b))
            Console.WriteLine(c);
        else if ((b > a) && (a > c))
            Console.WriteLine(a);
        else if ((c > a) && (a > b))
            Console.WriteLine(a);
        else if ((b > c) && (c > a))
            Console.WriteLine(c);
        else
            Console.WriteLine(b);
    }
}