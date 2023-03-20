using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collection
{
    public class Book
    {
        private long id;
        private string title;
        private string author;
        private string publisher;
        private string year;
        private double price;

        public Book()
        {

        }

        public Book(long id, string title, string author, string publisher, string year, double price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.price = price;
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set 
            {
                while (true)
                {
                    if (value == "" || value.Length > 35)
                    {
                        Console.Write("Please Double Check Sentence / Space Allow: ");
                        value = Console.ReadLine();
                        continue;
                    }

                    foreach (char item in value)
                    {
                        if (char.IsDigit(item))
                        {
                            Console.Write("Digits Are NotAllowed....\n");
                            Console.Write("Please Double Check Sentence / Space Allow:  ");
                            value = Console.ReadLine();
                            break;
                        }
                    }
                    break;
                }
                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public double Price
        { 
            get { return price; } 
            set { price = value; } 
        }



    }
}
