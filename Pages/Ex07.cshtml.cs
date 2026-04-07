using at.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at.Pages
{
    public class Ex07Model : PageModel
    {
        public List<PacoteTuristico> tourPackageList { get; set; } = new List<PacoteTuristico>
            {
                new PacoteTuristico { Id = 1, Titulo = "Pacote Europa", CapacidadeMaxima = 15, Preco = 15000m },
                new PacoteTuristico { Id = 2, Titulo = "Pacote Ásia", CapacidadeMaxima = 10, Preco = 3000m },
                new PacoteTuristico { Id = 3, Titulo = "Pacote América do Sul", CapacidadeMaxima = 17, Preco = 6000m },
            };
    }
}
