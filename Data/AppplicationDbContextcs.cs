using Microsoft.EntityFrameworkCore;
using Razor_Pizzeria.Models;

namespace Razor_Pizzeria.Data
{
    public class AppplicationDbContextcs : DbContext
    {
        public AppplicationDbContextcs(DbContextOptions<AppplicationDbContextcs> options) : base(options)
        {
        }

        public DbSet<PizzaOrder> PizzaOrders { get; set; }       
    }
}
