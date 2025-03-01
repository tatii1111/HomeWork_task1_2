namespace task_1_2_10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите габариты участка");
        Console.Write("a = ");
        double a = Math.Abs(double.Parse(Console.ReadLine()));
        Console.Write("b = ");
        double b = Math.Abs(double.Parse(Console.ReadLine()));
        Console.WriteLine("Введите габариты домов");
        Console.WriteLine("Габариты первого дома");
        Console.Write("p = ");
        double p = Math.Abs(double.Parse(Console.ReadLine()));
        Console.Write("q = ");
        double q = Math.Abs(double.Parse(Console.ReadLine()));
        Console.WriteLine("Габариты второго дома");
        Console.Write("r = ");
        double r = Math.Abs(double.Parse(Console.ReadLine()));
        Console.Write("s = ");
        double s = Math.Abs(double.Parse(Console.ReadLine()));
        if (((p + r <= a) || (q + r <= a) || (p + s <= a) || (q + s <= a)) || ((p + r <= b) || (q + r <= b) || (q + s <= b) || (p + s <= b)))
         Console.WriteLine("Дома можно разместить на участке");
        else 
            Console.WriteLine("Дома нельзя разместить на участке");
            
        
    }
}