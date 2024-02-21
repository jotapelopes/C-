using System;

namespace Exercicos;

internal class Program
{
	private static void Main(string[] args)
	{
		          //   int m = 12, n = 18;
            // if (m > 10)
            // {
            //     if (n > 20)
            //     {
            //         Console.WriteLine("Result1");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Result2");
            //     }
            // }
		double a = 1.0;
		double b = 5.0;
		double c = 6.0;
		double delta = b * b + 4.0 * a * c;
		Console.WriteLine(delta);
		double raiz1 = (0.0 - b + Math.Sqrt(delta)) / (2.0 * a);
		double raiz2 = (0.0 - b - Math.Sqrt(delta)) / (2.0 * a);
		Console.WriteLine("As raízes são" + raiz1 + raiz2);
		Console.ReadKey();
	}
}
