using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Console.Exercises
{
    internal class Exercise11
    {
        public static string ConcatenateName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public static string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }

        public static void Run()
        {
            Func<string, string, string> processName = ConcatenateName;

            processName += (first, last) => ToUpperCase(ConcatenateName(first, last));
            processName += (first, last) => RemoveSpaces(ToUpperCase(ConcatenateName(first, last)));

            Console.WriteLine("Digite seu nome: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            string lastName = Console.ReadLine();

            string result = processName(firstName, lastName);
            Console.WriteLine($"Resultado final: {result}");

            Console.WriteLine("\nNota: Em delegates multicast com retorno, apenas o último método retorna valor.");
            Console.WriteLine($"Resultado de ConcatenateName: {ConcatenateName(firstName, lastName)}");
            Console.WriteLine($"Resultado de ToUpperCase: {ToUpperCase(ConcatenateName(firstName, lastName))}");
            Console.WriteLine($"Resultado de RemoveSpaces: {RemoveSpaces(ToUpperCase(ConcatenateName(firstName, lastName)))}");
        }
    }
}
