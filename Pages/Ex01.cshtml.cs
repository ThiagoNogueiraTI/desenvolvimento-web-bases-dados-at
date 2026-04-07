using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace at.Pages
{
    public delegate decimal CalculateDelegate(decimal price);

    public class Ex01Model : PageModel
    {
        [BindProperty]
        public decimal Price { get; set; }

        public decimal? Result { get; set; }

        public void OnPost()
        {
            CalculateDelegate calculate = ApplyDiscount;
            Result = calculate(Price);
        }

        private decimal ApplyDiscount(decimal price)
        {
            return price - (price * 0.10m);
        }


    }
}