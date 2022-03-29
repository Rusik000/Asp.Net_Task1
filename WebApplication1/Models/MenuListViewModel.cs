using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class MenuListViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<HotMeal> HotMeals { get; set; }
        public List<FastFood> FastFoods { get; set; }
    }
}
