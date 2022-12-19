using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   static class ChooseAnswerFactory
    {
        public static IDrink Answer(string choice)
        {
            switch (choice.ToLower())
            {
                case ("rum runner"):
                    return new Mixed();
                    

                case ("whiskey sour"):
                    return new Mixed();
                   

                case ("old fashioned"):
                    return new Mixed();
                  

                case ("moscow mule"):
                    return new Mixed();
                   

                case ("whiskey"):
                    return new Straight();
                   

                case ("vodka"):
                    return new Straight();

                   

                case ("rum"):
                    return new Straight();
                  

                case ("bourbon"):
                    return new Straight();
                    

                default: 
                    return new Straight();


             




            }
        }
        

    }
}
