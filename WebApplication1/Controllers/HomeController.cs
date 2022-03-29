using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Moruqlu Buzlu Mix",
                    ImagePath="images/drink1.png"
                },

                 new Drink
                {
                    Id=2,
                    Name="Caffe Mocha",
                    ImagePath="images/drink2.png"
                },

                  new Drink
                {
                    Id=3,
                    Name="Portağal və Alma şirəsi",
                    ImagePath="images/drink3.png"
                },
                   new Drink
                {
                    Id=4,
                    Name="Dondurmalı Buzlu Qəhvə",
                    ImagePath="images/drink4.png"
                }

            };
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id=1,
                    Name="Neapolitan Souslu Fındıq Köftə",
                    ImagePath="images/hotmeal1.png"
                },
                  new HotMeal
                {
                    Id=2,
                    Name="Kahraman Maraş Yoğurtlu Kabab",
                    ImagePath="images/hotmeal2.png"
                },
                    new HotMeal
                {
                    Id=3,
                    Name="Tərəvəzli Can Əti Bükməsi",
                    ImagePath="images/hotmeal3.jpg"
                },
                      new HotMeal
                {
                    Id=4,
                    Name="Quzu Ətli Nar Qovurma",
                    ImagePath="images/hotmeal4.png"
                }

            };
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Toyuq Sendviç",
                    ImagePath="images/fastfood1.jpg"
                },
                new FastFood
                {
                    Id=2,
                    Name="Çizburger",
                    ImagePath="images/fastfood2.png"
                },
                new FastFood
                {
                    Id=3,
                    Name="Ağ Pendirli Gözləmə",
                    ImagePath="images/fastfood3.png"
                },
                new FastFood
                {
                    Id=4,
                    Name="Kaşar Pendirli Tost",
                    ImagePath="images/fastfood4.png"
                }
            };
            var model = new MenuListViewModel
            {
                Drinks=drinks,
                HotMeals=hotMeals,
                FastFoods=fastFoods      
            };
            return View(model);
        }

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Moruqlu Buzlu Mix",
                    ImagePath="../images/drink1.png"
                },

                 new Drink
                {
                    Id=2,
                    Name="Caffe Mocha",
                    ImagePath="../images/drink2.png"
                },

                  new Drink
                {
                    Id=3,
                    Name="Portağal və Alma şirəsi",
                    ImagePath="../images/drink3.png"
                },
                   new Drink
                {
                    Id=4,
                    Name="Dondurmalı Buzlu Qəhvə",
                    ImagePath="../images/drink4.png"
                }

            };

            return View(drinks);
        }

        public IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id=1,
                    Name="Neapolitan Souslu Fındıq Köftə",
                    ImagePath="../images/hotmeal1.png"
                },
                  new HotMeal
                {
                    Id=2,
                    Name="Kahraman Maraş Yoğurtlu Kabab",
                    ImagePath="../images/hotmeal2.png"
                },
                    new HotMeal
                {
                    Id=3,
                    Name="Tərəvəzli Can Əti Bükməsi",
                    ImagePath="../images/hotmeal3.jpg"
                },
                      new HotMeal
                {
                    Id=4,
                    Name="Quzu Ətli Nar Qovurma",
                    ImagePath="../images/hotmeal4.png"
                }

            };
            return View(hotMeals);
        }

        public IActionResult FastFood()
        {
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Toyuq Sendviç",
                    ImagePath="../images/fastfood1.jpg"
                },
                new FastFood
                {
                    Id=2,
                    Name="Çizburger",
                    ImagePath="../images/fastfood2.png"
                },
                new FastFood
                {
                    Id=3,
                    Name="Ağ Pendirli Gözləmə",
                    ImagePath="../images/fastfood3.png"
                },
                new FastFood
                {
                    Id=4,
                    Name="Kaşar Pendirli Tost",
                    ImagePath="../images/fastfood4.png"
                }
            };
            return View(fastFoods);

        }
    }
}
