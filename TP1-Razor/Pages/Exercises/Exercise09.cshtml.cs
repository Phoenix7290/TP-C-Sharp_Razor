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
            Answer1 = "A pasta Pages cont�m as Razor Pages da aplica��o. Cada arquivo .cshtml representa uma p�gina, e seu code-behind (arquivo .cs) define a l�gica associada. � onde o modelo de dados e os manipuladores de requisi��es (como OnGet, OnPost) s�o implementados.";
            Answer2 = "O arquivo Program.cs � o ponto de entrada da aplica��o. Ele configura e inicia o host da aplica��o, definindo o pipeline de inicializa��o e chamando o m�todo CreateHostBuilder para configurar servi�os e o pipeline de requisi��es.";
            Answer3 = "Os servi�os da aplica��o s�o configurados no arquivo Startup.cs (em vers�es mais antigas do ASP.NET Core) ou diretamente no Program.cs (em vers�es mais recentes, como .NET 6+). Usa-se o m�todo AddServices para registrar servi�os no cont�iner de inje��o de depend�ncia.";
            Answer4 = "O roteamento de URLs em Razor Pages � feito automaticamente com base na estrutura de arquivos na pasta Pages. Por exemplo, um arquivo Pages/Exercises/Exercise9.cshtml � mapeado para a URL '/Exercises/Exercise9'. O atributo @page no in�cio do arquivo .cshtml define a rota.";
        }
    }
}
