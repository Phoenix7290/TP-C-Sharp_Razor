using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1_Razor.Pages.Exercises
{
    public class Exercise09Model : PageModel
    {
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }

        public void OnGet()
        {
            Answer1 = "A pasta Pages contém as Razor Pages da aplicação. Cada arquivo .cshtml representa uma página, e seu code-behind (arquivo .cs) define a lógica associada. É onde o modelo de dados e os manipuladores de requisições (como OnGet, OnPost) são implementados.";
            Answer2 = "O arquivo Program.cs é o ponto de entrada da aplicação. Ele configura e inicia o host da aplicação, definindo o pipeline de inicialização e chamando o método CreateHostBuilder para configurar serviços e o pipeline de requisições.";
            Answer3 = "Os serviços da aplicação são configurados no arquivo Startup.cs (em versões mais antigas do ASP.NET Core) ou diretamente no Program.cs (em versões mais recentes, como .NET 6+). Usa-se o método AddServices para registrar serviços no contêiner de injeção de dependência.";
            Answer4 = "O roteamento de URLs em Razor Pages é feito automaticamente com base na estrutura de arquivos na pasta Pages. Por exemplo, um arquivo Pages/Exercises/Exercise9.cshtml é mapeado para a URL '/Exercises/Exercise9'. O atributo @page no início do arquivo .cshtml define a rota.";
        }
    }
}
