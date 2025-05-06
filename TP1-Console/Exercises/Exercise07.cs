using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Console.Exercises
{
    internal class Exercise07
    {
        public class Logger
        {
            public Action<string> LogMessage;

            public void LogToConsole(string message)
            {
                Console.WriteLine($"[Console] {message}");
            }

            public void LogToFile(string message)
            {
                Console.WriteLine($"[Arquivo] {message}");
            }

            public void LogToDatabase(string message)
            {
                Console.WriteLine($"[Banco] {message}");
            }
        }

        public static void Run()
        {
            Logger loggerWithMethods = new Logger();
            loggerWithMethods.LogMessage += loggerWithMethods.LogToConsole;
            loggerWithMethods.LogMessage += loggerWithMethods.LogToFile;
            loggerWithMethods.LogMessage += loggerWithMethods.LogToDatabase;

            Console.WriteLine("Teste 1 - Com métodos associados:");
            Console.WriteLine("Digite uma mensagem para registrar: ");
            string message = Console.ReadLine();
            loggerWithMethods.LogMessage?.Invoke(message); 

            Logger loggerWithoutMethods = new Logger();
            Console.WriteLine("\nTeste 2 - Sem métodos associados:");
            loggerWithoutMethods.LogMessage?.Invoke("Mensagem de teste");
            Console.WriteLine("Nenhuma exceção ocorreu!");
        }
    }
}
