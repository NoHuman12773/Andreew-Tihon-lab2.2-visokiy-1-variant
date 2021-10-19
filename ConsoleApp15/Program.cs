using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, c;
                Console.WriteLine("Введите a");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите c");
                c = double.Parse(Console.ReadLine());

                double d = b * b - 4 * a * c;

                if (d >= 0)
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
                else
                {
                    Console.WriteLine(" Уравнение не имеет корней");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
