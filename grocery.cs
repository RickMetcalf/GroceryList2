using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList2
{
    internal class Grocery
    {
        public string FoodName { get; set; }
        public int FoodQuanity { get; set; }    
        public double PricePerItem { get; set; } 
        public double TotalPrice { get; set; }

        /*public grocery()
        {

        }

        public grocery(string _foodname, int _foodquanity, double _priceperitem, double _totalprice)
        {
            FoodName = _foodname;
            FoodQuanity = _foodquanity;
            PricePerItem = _priceperitem;
            TotalPrice = _totalprice;
        }*/



    }
}
