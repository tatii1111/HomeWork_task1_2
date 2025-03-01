namespace task_1_2_3;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите четыре числа:");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("d = ");
        double d = Convert.ToDouble(Console.ReadLine());
        if ((a > b) && (a > c) && (a > d))
            Console.WriteLine(a);
        else if ((b > a) && (b > c) && (b > d))
            Console.WriteLine(b);
        else if ((c > a) && (c > b) && (c > d))
            Console.WriteLine(c);
        else
            Console.WriteLine(d);
    }
}