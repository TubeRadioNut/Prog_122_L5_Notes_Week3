using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_L5_Notes_Week3
{
    internal class Product
    {

        //fields
        private int _uId;
        private string _title;
        private string _director;
        private double _rating;
        private decimal _price;

        //constructors
        public Product(string title, string director)//overloading, method signitures have to be different
        {
            Random random = new Random();
            UId = random.Next(100000000, 1000000000);
            _title = title;
            Director = director;
            Rating = 0.0;//default value
            Price = 0.0m;//default value
        }
        
        public Product(string title, string director, double rating, decimal price)
        {
            Random random = new Random();
            UId = random.Next(100000000, 1000000000);
            _title = title;
            Director = director;
            Rating = rating;
            Price = price;
        }

        //Properties
        //Getters
        //Setters
        public string GetTitle()
        {
            return _title;
        }//getTitle()

        public void SetTitle(string title)
        {
            _title = title;
        }
        //Getter and Setter
        //no Parenthese
        //same return type as field
        public string Title
        {
            get 
            { 
                return _title; 
            }

            set 
            { 
                _title = value; 
            }
        }
        //properties
        public decimal Price 
        {
            get => _price; 
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    throw new Exception("Enter a value Greater Than 0");
                }
                
            } 
        }
        public string Director { get => _director; set => _director = value; }
        public double Rating { get => _rating; set => _rating = value; }
        public int UId { get => _uId; private set => _uId = value; }
    }//end of the class
    


    //method


}

