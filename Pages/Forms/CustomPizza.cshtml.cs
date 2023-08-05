using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pizzeria.Models;

namespace WebApplication3.Pages.Forms
{
    public class CustomModel : PageModel
    {
        [BindProperty]
        public PizzasModel? Pizza { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost ()
        {
            float pizzaPrice = 0;
            pizzaPrice = Pizza.BasePrice;


            if (Pizza.TomatoSauce) pizzaPrice += 1;
            if (Pizza.Cheese) pizzaPrice += 1;
            if (Pizza.Peporoni) pizzaPrice += 1;
            if (Pizza.Mushroom) pizzaPrice += 1;
            if (Pizza.Tuna) pizzaPrice += 1;
            if (Pizza.Pineapple) pizzaPrice += 10;
            if (Pizza.Hum) pizzaPrice += 1;
            if (Pizza.Beef) pizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new{Pizza.PizzaName, pizzaPrice });

        }
    }
}
