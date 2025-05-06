using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Console.Exercises
{
    internal class Exercise03
    {
        public static Func<double, double, double> CalculateArea = (baseLength, height) => baseLength * height;

        public static void Run()
        {
            Console.WriteLine("Digite a base do retângulo: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(baseLength, height);
            Console.WriteLine($"A área do retângulo é: {area}");
        }
    }
}
