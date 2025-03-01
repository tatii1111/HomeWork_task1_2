namespace task_1_2_6;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        string b = (a % 2 == 0) ? "Да" : "Нет";
        Console.WriteLine(b);
    }
}