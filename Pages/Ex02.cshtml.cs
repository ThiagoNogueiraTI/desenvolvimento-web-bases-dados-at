using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace at.Pages
{
    public class Ex02Model : PageModel
    {
        [BindProperty]
        public string Operation { get; set; } = string.Empty;

        public void OnPost()
        {
            Action<string> log = LogToConsole;
            log += LogToFile;
            log += LogToMemory;

            log(Operation);
        }

        public void LogToConsole(string message)
        {
            Console.WriteLine($"Mensagem do Console: {message}");
        }

        public void LogToFile(string message)
        {
            Console.WriteLine($"Mensagem do Arquivo: {message}");
        }

        public void LogToMemory(string message)
        {
            Console.WriteLine($"Mensagem da Memória: {message}");
        }
    }
}
