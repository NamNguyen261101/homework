using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace btvn5
{
    class Book
    {
        private long id;
        private string title;
        private float price;
        private string publisher;


        public Book()
        {

        }

        public Book(long id, string title, float price, string publisher)
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.publisher = publisher;
        }

        public long Id
        {
            get { return id; }
            private set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public float Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }

        public string Publisher
        {
            get { return publisher; }
            private set
            {
                
                 publisher = value;
            }
        }

        public void SetPublisher(string publisher)
        {
            TextInfo txtInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
            this.publisher = txtInfo.ToTitleCase(publisher);
        }

        public override string ToString()
        {
            return "Book: " + Title + ", price:  " + Price + ", publisher:  " + Publisher;
        }
        

    }
}
