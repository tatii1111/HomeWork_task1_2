namespace task_1_2_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        string b = (a % 10 == 0) ? "Да" : "Нет";
        Console.WriteLine(b);
    }
}