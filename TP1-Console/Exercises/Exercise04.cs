using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Console.Exercises
{
    internal class Exercise04
    {
        public class TemperatureSensor
        {
            public event Action<double> TemperatureExceeded;

            public void CheckTemperature(double temperature)
            {
                Console.WriteLine($"Temperatura lida: {temperature}ºC");
                if (temperature > 100)
                {
                    TemperatureExceeded?.Invoke(temperature);
                }
            }
        }

        public static void Run()
        {
            TemperatureSensor sensor = new TemperatureSensor();

            sensor.TemperatureExceeded += (temp) => Console.WriteLine($"ALERTA: Temperatura {temp}ºC ultrapassou o limite de 100ºC!");

            while (true)
            {
                Console.WriteLine("\nDigite uma temperatura (ou 'sair' para encerrar): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair") break;

                if (double.TryParse(input, out double temperature))
                {
                    sensor.CheckTemperature(temperature);
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Digite um número ou 'sair'.");
                }
            }
        }
    }
}
