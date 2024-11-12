using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Singleresponsibility.ViolatePrinciple
{
    internal class Invoice
    {
        public Book Book { get; set; }
        public int Quanitity { get; set; }
        public double DiscountRate { get; set; }
        public double TaxRate { get; set; }
        public double Total { get; set; }
        public Invoice(Book book, int quanitity, double discountRate, double taxRate)
        {
            Book = book;
            Quanitity = quanitity;
            DiscountRate = discountRate;
            TaxRate = taxRate;
            Total = CalculateTotal();
        }
        public double CalculateTotal()
        {
            double Price = (Book.Price - (Book.Price * DiscountRate)) * Quanitity;
            double PriceWithTaxes = Price*TaxRate;
            return PriceWithTaxes;
        }
        public void PrintInvoice()
        {
            Console.WriteLine($"BookName : { Book.Name} - BookPrice : {Book.Price} - Quantity : {Quanitity} - Discount : {DiscountRate} - Total : {Total}");

        }
        public void SaveToFile (string filename)
        {
            Console.WriteLine();
        }
    }
}
