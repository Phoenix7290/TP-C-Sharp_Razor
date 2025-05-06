using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TP1_Console.Exercises
{
    internal class Exercise05
    {
        public class DownloadManager
        {
            public event Action DownloadCompleted;

            public void StartDownload(string fileName)
            {
                Console.WriteLine($"Iniciando download de {fileName}...");
                Thread.Sleep(3000); 
                Console.WriteLine($"Download de {fileName} concluído!");
                DownloadCompleted?.Invoke(); 
            }
        }

        public static void Run()
        {
            DownloadManager manager = new DownloadManager();

            manager.DownloadCompleted += () => Console.WriteLine("Notificação: O download foi concluído com sucesso!");

            manager.StartDownload("arquivo.zip");
        }
    }
}
