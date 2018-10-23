using SumaNuget;
using System;

namespace SumaNugetText
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumator sumator = new Sumator();

            decimal[] decimalValues = new decimal[] { 2.5m, 1.7m, 6.2m };
            Console.WriteLine("Sumando decimales...");
            Console.WriteLine($"Valores: {string.Join(", ", decimalValues)}");
            Console.WriteLine($"Resultado: {sumator.Suma(decimalValues)}");

            Console.WriteLine();

            int[] intValues = new int[] { 2, 1, 6 };
            Console.WriteLine("Sumando enteros...");
            Console.WriteLine($"Valores: {string.Join(", ", intValues)}");
            Console.WriteLine($"Resultado: {sumator.Suma(intValues)}");

            Console.WriteLine();
            Console.WriteLine("PULSA CUALQUIER TECLA PARA SALIR");
            Console.ReadLine();
        }
    }
}
