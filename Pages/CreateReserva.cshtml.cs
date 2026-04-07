using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace at.Pages
{
    public class CreateReservaModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
        public string ClientName { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            Message = $"Reserva cadastrada com sucesso para o cliente {ClientName}.";
        }
    }
}
