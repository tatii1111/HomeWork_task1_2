namespace task_1_2_9;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        string b = (((a <= -10) || (a >= 10))) ? "Да" : "Нет";
        Console.WriteLine(b);
    }
}