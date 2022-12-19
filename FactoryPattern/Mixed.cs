using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Mixed : IDrink
    {
        public Mixed()
        {

        }
        public double MPrice { get; set; } = 5.00;
 

        public void Drink()
        {
            Console.WriteLine($"The price of the mixed drinks are {MPrice}");
        }
    }
}
