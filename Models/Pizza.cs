using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPracticeAPI.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public String PizzaName { get; set; }

        public bool IsGlutenFree { get; set; }
    }
}
