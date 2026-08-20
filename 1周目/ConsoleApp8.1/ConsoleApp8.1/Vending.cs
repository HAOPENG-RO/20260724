using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8._1
{
    internal class Vending
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Vending(int number,string name,int price,int stock) {
            Number = number;
            Name = name;
            Price = price; 
            Stock = stock;
        }
    }
}
