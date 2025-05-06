using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Console.Exercises
{
    internal class Exercise01
    {
        public delegate decimal CalculateDiscount(decimal price);

        public static void Run()
        {
            Console.WriteLine("Digite o preço original do produto: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            CalculateDiscount discount = (p) => p * 0.9m;

            decimal finalPrice = discount(price);
            Console.WriteLine($"Preço final com 10% de desconto: {finalPrice:C}");
        }
    }
}
