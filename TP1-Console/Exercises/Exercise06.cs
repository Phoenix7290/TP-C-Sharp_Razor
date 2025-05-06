using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Console.Exercises
{
    internal class Exercise06
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
            Logger logger = new Logger();

            logger.LogMessage += logger.LogToConsole;
            logger.LogMessage += logger.LogToFile;
            logger.LogMessage += logger.LogToDatabase;

            Console.WriteLine("Digite uma mensagem para registrar: ");
            string message = Console.ReadLine();

            logger.LogMessage(message);
        }
    }
}
