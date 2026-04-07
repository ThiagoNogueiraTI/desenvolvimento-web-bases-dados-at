using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace at.Pages
{
    public class CreateDestinoModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "O país é obrigatório.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O país deve ter entre 3 e 50 caracteres.")]
        public string Country { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            Message = $"Destino {Name} no país {Country} foi cadastrado com sucesso.";
        }
    }
}
