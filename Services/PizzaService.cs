using PizzaPracticeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPracticeAPI.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas { get; }
        static int nextId = 3;
        static PizzaService()
        {
            Pizzas = new List<Pizza>
           {
               new Pizza{Id = 1, PizzaName = "Hawaaian", IsGlutenFree = true},
               new Pizza { Id = 2, PizzaName = "BBQ Steak", IsGlutenFree = false},
               new Pizza {Id = 3, PizzaName = "Borewores", IsGlutenFree = false}
           };
        }

        public static List<Pizza> GetAll()
        {
            return Pizzas;
        }

        public static Pizza GetPizza(int id)
        {
            return Pizzas.FirstOrDefault(x => x.Id == id);
        }

        public static void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }
        public static void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index == -1)
                return;

            Pizzas[index] = pizza;
        }

        public static void Delete(int id)
        {
            var pizza = GetPizza(id);
            if (pizza is null)
                return;

            Pizzas.Remove(pizza);
        }
    }
}



























           
