namespace task_1_2_7;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Math.Abs(a / 10);
        if ((b >= 1) && (b < 10))
            Console.WriteLine("Да");
        else
            Console.WriteLine("Нет");
    }
}