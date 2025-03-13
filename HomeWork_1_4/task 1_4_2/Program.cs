namespace task_1_4_2;

class Program
{                                                       
    static void Main()
    {
        Console.WriteLine("Введите натуральное число");
        Console.Write("n = ");
        int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        double k = Math.Pow(n, -1);
        
        for ( int i = 1; i < n ; i++)
            k = k + Math.Pow(i, -1);
            
        Console.WriteLine(k);
    }
}