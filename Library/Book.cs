using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        string name;
        int year;
        string author = Author.name;
        double price;

        public Book(string name, int year, string author, double price)
        {
            this.name = name;
            this.year = year;
            this.price = price;
        }

        public void PrintBook()
        {
            Console.WriteLine("Book {0} ({1}), by {2}, published in {3}", name, price, author, year);
        }
    }
}
