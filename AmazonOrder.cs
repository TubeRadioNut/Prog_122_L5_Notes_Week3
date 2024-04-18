using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_L5_Notes_Week3
{
    internal class AmazonOrder
    {
        //Fields 
        string _orderId;
        string _name;
        List<Product> _products;
        decimal _tax;
        //Constructor
        public AmazonOrder(string orderId, string name, decimal tax)
        {
            _orderId = orderId;
            _name = name;
            _tax = tax;
            _products = new List<Product>();
        }
        //Properties
        public string OrderId { get => _orderId; set => _orderId = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        internal List<Product> Products { get => _products; set => _products = value; }



        

        //Methods
        public decimal TotalPrice()
        {
            decimal totalPrice = 0m;
            //Loop through our product list
            foreach(Product product in _products)
            {
                //adding the price of each individual to our total product
                totalPrice += product.Price;
            }
            //calculate the final price
            totalPrice *= (1 + _tax);
            

            return totalPrice;
        }

    }//end of the class


}//namespace
