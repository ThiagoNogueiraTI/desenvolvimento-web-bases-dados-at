using at.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at.Pages
{
    public class Ex04Model : PageModel
    {

        [BindProperty]
        public int ReservationCount { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            Reserva reservation = new Reserva();
            reservation.PacoteTuristico = new PacoteTuristico { CapacidadeMaxima = 5 };

            reservation.CapacityReached += (message) => Console.WriteLine($"{message}");

            reservation.CheckCapacity(ReservationCount);

            Message = "Conferir logs no console.";
        }
    }
}
