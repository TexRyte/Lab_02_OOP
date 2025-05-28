using System;

class Program
{   // Ex 1
    static double VolumeOfTrianglePrism(double a, double h)
    {
        double S = (Math.Sqrt(3) / 4) * a * a;
        return S * h;
    }

    static void Main()
    {
        try
        {
            Console.Write("Введіть a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введіть h: ");
            double h = double.Parse(Console.ReadLine());
            
            double S = (Math.Sqrt(3) / 4) * a * a;
            double V = S * h;

            Console.WriteLine($"Об'єм правильної трикутної призми: {V:F2}");
            Console.WriteLine($"Об'єм правильної трикутної призми: {VolumeOfTrianglePrism(a, h):F2}");
        }
        catch
        {
            Console.WriteLine("Некоректне введення!");
        }




        // Ex 2
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());

        if (x > Math.PI / 6 && x < Math.PI / 4)
        {
            Console.WriteLine(1 / Math.Cos(x));
        }
        else if ( x > Math.PI / 4 && x < Math.PI / 3)
        {
            Console.WriteLine(-Math.Tan(x));
        }
        else
        {
            Console.WriteLine("Некоректне введення!");
        }

    }
}
