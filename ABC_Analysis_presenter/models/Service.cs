using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Analysis_presenter.models
{
    public class Service
    {
        private double totalPrice = 0;
        public double Price { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public double TotalPrice { set { totalPrice = value; } get { return totalPrice == 0 ? Price * Count: totalPrice; } }

        public Service(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }

        public Service(string name, int count, double price, double totalPrice) : this(name, count, price)
        {
            TotalPrice = totalPrice;
        }
    }
}
