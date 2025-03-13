namespace task_1_4_3;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите положительные целые числа");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        if (b <= 0 || a <= 0)
            Console.WriteLine("Введенные значения должны быть положительными");
        int i = 1;
        double k = 1;
        while (i <= b)
        {
            k = k * a;
            i++;
        }
        Console.WriteLine(k);
        Console.ReadKey();
    }
}