using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Console.Exercises
{
    internal class Exercise02
    {
        public static Action<string> WelcomePortuguese = (name) => Console.WriteLine($"Bem-vindo, {name}!");
        public static Action<string> WelcomeEnglish = (name) => Console.WriteLine($"Welcome, {name}!");
        public static Action<string> WelcomeSpanish = (name) => Console.WriteLine($"¡Bienvenido, {name}!");

        public static void Run()
        {
            Console.WriteLine("Escolha um idioma (1 - Português, 2 - Inglês, 3 - Espanhol): ");
            string choice = Console.ReadLine();

            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WelcomePortuguese(name);
                    break;
                case "2":
                    WelcomeEnglish(name);
                    break;
                case "3":
                    WelcomeSpanish(name);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
