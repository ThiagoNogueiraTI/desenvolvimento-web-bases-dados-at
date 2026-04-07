using at.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at.Pages
{
    public class PacoteTuristicoDetailsModel : PageModel
    {
        public PacoteTuristico TourPackage { get; set; }

        public IActionResult OnGet(int id)
        {
            var tourPackageList = new List<PacoteTuristico>
            {
                new PacoteTuristico { Id = 1, Titulo = "Pacote Europa", CapacidadeMaxima = 15, Preco = 15000m },
                new PacoteTuristico { Id = 2, Titulo = "Pacote Ásia", CapacidadeMaxima = 10, Preco = 3000m },
                new PacoteTuristico { Id = 3, Titulo = "Pacote América do Sul", CapacidadeMaxima = 17, Preco = 6000m },
            };

            TourPackage = tourPackageList.FirstOrDefault(p => p.Id == id);

            if (TourPackage == null)
            {
                TempData["Message"] = "Pacote não encontrado.";
                return RedirectToPage("Ex07");
            }

            return Page();
        }
    }
}
