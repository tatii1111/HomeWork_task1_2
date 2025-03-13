using System.Diagnostics; 
namespace task_1_4_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число из диапазона [20;60]");
        double a = double.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Введите число из диапазона [20;60]");
            a = double.Parse(Console.ReadLine());
        } 
        while (((a < 20) || (a > 60)));
        Console.WriteLine("Вы ввели корректное число");
    }
}