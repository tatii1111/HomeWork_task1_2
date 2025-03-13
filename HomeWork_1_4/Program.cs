namespace task_1_4_1;

class Program
{
    static void Main()
    {
     Console.WriteLine("Введите натуральное число");
     Console.Write("n = ");
     int n = Math.Abs(int.Parse(Console.ReadLine()));
     int k = n;
     for (int i = 1; i < n; i++)
         k = k * i;
     Console.WriteLine(k);
    }
}