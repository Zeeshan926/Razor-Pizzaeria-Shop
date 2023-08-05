using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Pizzeria.Models;

namespace WebApplication3.Pages
{
    public class pizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new()
        {
            new PizzasModel(){ImageTitle= "Margrata",PizzaName="Margrata", BasePrice=2,TomatoSauce=true,Cheese=true, FinalPrice=4 },
            new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=2, TomatoSauce=true, Cheese=true, Beef=true, FinalPrice=5 },
            new PizzasModel(){ImageTitle="Hawaiin", PizzaName="Hawaiin", BasePrice=2, TomatoSauce=true, Cheese=true, Hum=true, Pineapple=true, FinalPrice=15 },
            new PizzasModel(){ImageTitle="MeetFeast", PizzaName="MeetFeast", BasePrice=2, TomatoSauce=true, Cheese=true, Hum=true, Mushroom=true, FinalPrice=6 },
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true, Hum=true, Beef=true, FinalPrice= 6 },
            new PizzasModel(){ImageTitle="Pepporani", PizzaName="Pepporani", BasePrice=2, TomatoSauce=true, Cheese=true, Mushroom=true, FinalPrice= 5},
            new PizzasModel(){ImageTitle="stock", PizzaName="stock", BasePrice=2, TomatoSauce=true, Cheese=true, Peporoni=true, FinalPrice= 5 },
            new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=2, TomatoSauce=true, Cheese=true, Tuna=true, FinalPrice= 5 },
            new PizzasModel(){ImageTitle="Vegeterian", PizzaName="Vegeterian", BasePrice=2,  TomatoSauce=true, Cheese=true, Mushroom=true, Pineapple=true, FinalPrice =12 },
        };

        public void OnGet()
        {
        }
    }
}  
