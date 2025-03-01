namespace task1_2_1;

public static class Program 
{ 
    public static void Main()
    {
        Console.WriteLine("Введите два числа:");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a > b)
            Console.WriteLine("Результат: >");
        else if (a < b)
            Console.WriteLine("Результат: <");
        else
            Console.WriteLine("Результат: =");
    }
}