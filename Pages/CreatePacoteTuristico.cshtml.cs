using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace at.Pages
{
    public class CreatePacoteTuristicoModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "O título é obrigatório.")]
        [MinLength(3, ErrorMessage = "O título deve ter pelo menos 3 caracteres.")]
        public string Title { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            Message = $"Pacote '{Title}' cadastrado com sucesso.";
        }
    }
}
