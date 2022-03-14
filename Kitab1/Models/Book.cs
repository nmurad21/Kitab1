using System;
using System.Collections.Generic;
using System.Text;

namespace Kitab1.Models
{
    class Book:Product
    {
        public string Genre;
        public Book(string Genre, int No, string Name, int Price, int Count) : base(No, Name, Price, Count)
        {
            this.Genre = Genre;
        }
    }
}
