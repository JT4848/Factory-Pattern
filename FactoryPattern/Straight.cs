using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Straight : IDrink
    {
        public Straight()
        {

        }
        public double StrPrice { get; set; } = 4.00;
      

        public void Drink()
        {
            Console.WriteLine($"The price of the straight drinks are {StrPrice}");
        }
    }
}
