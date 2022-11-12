using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class food
    {
        public string FoodName;
        private double _price;

        private double _discount;  

        public double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 150)
                {
                    value = (value - (0.1 * value));
                }
                _price = value;
            }
            
        }
        public void ShowData()
        {
            Console.WriteLine($"\nName : {FoodName}");
            Console.WriteLine($"Price : {Price}");

        }


    }
    

}
