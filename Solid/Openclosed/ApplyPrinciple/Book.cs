using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Openclosed.ApplyPrinciple
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Book(int _id, string _name, string _author, int _year, double _Price)
        {
            Id = _id;
            Name = _name;
            Author = _author;
            Year = _year;
            Price = _Price;
        }
    }
}
