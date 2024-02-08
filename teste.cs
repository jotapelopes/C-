namespace ConsoleApp2
{
    internal class Program
    {
        static double Main(string[] args, double? raio)
        {
            //Console.WriteLine("Digite o primeiro lado do retângulo: ");
            //double? var1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite o segundo lado do retângulo: ");
            //double? var2 = Convert.ToDouble(Console.ReadLine());

            //double? areaInput = var1 * var2;

            //Console.WriteLine(areaInput);

            //Console.WriteLine("Faça um programa que calcule o VOLUME de qualquer CUBO");

            //Console.WriteLine("Digite o lado do cubo");
            //double? cubo1 = Convert.ToDouble(Console.ReadLine());

            //double? elevCubo = Math.Pow((double)cubo1, 3);

            //Console.WriteLine("O número elevado ao cubo é: " + elevCubo);

            Console.WriteLine("Faça um programa para calcular a area de qualquer circunferência");

            Console.WriteLine("Digite o raio da circunferência em questão");
            double? raio1 = Convert.ToDouble(Console.ReadLine());

            double? areaCircunf = 3.14 * Math.Pow((double)raio1, 2);

            Console.WriteLine("A área da circunferência é: " + areaCircunf);

        }
    }
}
