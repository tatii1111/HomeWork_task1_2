namespace task_1_2_2;

class Program
{
    static void Main()
    
    {
        Console.WriteLine("Введите три числа:");
        Console.WriteLine("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("c = ");
        double c = Convert.ToDouble(Console.ReadLine());
        if ((a > b) && (a > c))
            Console.WriteLine(a);
        else if ((b > a) && (b > c))
            Console.WriteLine(b);
        else
            Console.WriteLine(c);
    }
}