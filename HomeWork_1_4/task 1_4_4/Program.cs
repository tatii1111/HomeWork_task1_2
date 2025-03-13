namespace task_1_4_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целые числа, a >0, b < 0");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        if (b >= 0)
        {
            Console.WriteLine("Введенные значения не попадают в диапазон условия");
            return;
        }
    int i = 0;
        double k = 1;
        while (i > b)
        {
            k /= a;
            i--;
        }
        Console.WriteLine(k);
        Console.ReadKey();
    }
}