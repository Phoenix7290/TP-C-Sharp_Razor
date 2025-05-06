using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Selecione um exercício (1-5, 7, 11) ou 'sair' para encerrar:");
            Console.WriteLine("1 - Delegate de Desconto");
            Console.WriteLine("2 - Ações Multilíngues");
            Console.WriteLine("3 - Cálculo de Área");
            Console.WriteLine("4 - Monitoramento de Temperatura");
            Console.WriteLine("5 - Notificação de Download");
            Console.WriteLine("6 - Sistema de Registro");
            Console.WriteLine("7 - Robustez de Delegates");
            Console.WriteLine("11 - Manipulação de Strings");
            var input = Console.ReadLine();

            if (input.ToLower() == "sair") break;

            switch (input)
            {
                case "1": 
                    TP1_Console.Exercises.Exercise01.Run(); 
                    break;
                case "2": 
                    TP1_Console.Exercises.Exercise02.Run(); 
                    break;
                case "3": 
                    TP1_Console.Exercises.Exercise03.Run(); 
                    break;
                case "4": 
                    TP1_Console.Exercises.Exercise04.Run(); 
                    break;
                case "5": 
                    TP1_Console.Exercises.Exercise05.Run(); 
                    break;
                case "6":
                    TP1_Console.Exercises.Exercise06.Run();
                    break;
                case "7": 
                    TP1_Console.Exercises.Exercise07.Run(); 
                    break;
                case "11": 
                    TP1_Console.Exercises.Exercise11.Run(); 
                    break;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }
    }
}