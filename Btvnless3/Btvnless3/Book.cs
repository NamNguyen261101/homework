using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvnless3
{
    public class Book
    {
        private string author;
        private int pages;
        private string isbn;
        private string title;
        private int currentPage;


        private int pageFlip;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }

        public int PageFlip
        {
            get { return pageFlip; }
            set { pageFlip = value; }

        }
        public Book()
        {

        }

        public Book (string author, int pages, string isbn, string title)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = 1;
        }

        public Book(string author, int pages, string isbn, string title, int currentPage)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = currentPage;
        }

      
        public int FlipPageFoward(int currentPage, int pages)
        {

            if (currentPage > 1 && currentPage < pages)
            {

                this.currentPage = currentPage++;
               
            }

            return this.currentPage += 1;
        }

        public int FlipPageBackward(int currentPage, int pages)
        {
            if (currentPage < 1)
            {
                Console.WriteLine("No more page to flip");
                this.currentPage = 1;
            }

            if (pages > currentPage)
            {

                this.currentPage = currentPage--;
            }
            
            return this.currentPage -= 1;
        }


    }
}
