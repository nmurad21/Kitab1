using System;
using System.Collections.Generic;
using System.Text;

namespace Kitab1.Models
{
    class Product
    {
        public int No;
        public string Name;
        public int Price;
        public int Count;

        public Product(int No, string Name, int Price, int Count)
        {
            this.No = No;
            this.Name = Name;
            this.Price = Price;
            this.Count = Count;
        }
    }
}
