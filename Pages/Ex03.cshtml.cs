using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at.Pages
{
    public class Ex03Model : PageModel
    {
        [BindProperty]
        public int Participants { get; set; }

        [BindProperty]
        public decimal PackagePrice { get; set; }

        public decimal? Total { get; set; }

        public void OnPost()
        {
            Func<int, decimal, decimal> calculateTotal = (participants, price) => participants * price;

            Total = calculateTotal(Participants, PackagePrice);
        }
    }
}
