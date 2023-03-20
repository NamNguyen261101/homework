using Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class BookTest
    {
        private List<Book> books = null;

        public BookTest()
        {
            books = new List<Book>();
        }

        private long GenerateId()
        {
            long max = 1;
            if (books != null && books.Count > 0)
            {
                max = books[0].Id;
                foreach (Book book in books)
                {
                    if (max < book.Id)
                    {
                        max = book.Id;
                    }
                }
                max++;
            }
            return max;
        }

        public void InputBook()
        {
            // Generate Book
            Book book = new Book();

            book.Id = GenerateId();

            Console.WriteLine("Title : ");
            book.Title = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Author : ");
            book.Author = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Publisher : ");
            book.Publisher = Convert.ToString(Console.ReadLine()); 

            Console.WriteLine("Year : ");
            book.Year = Convert.ToString(Console.ReadLine()); 

            Console.WriteLine("Price : ");
            book.Price = Convert.ToDouble(Console.ReadLine());

            books.Add(book);
        }

        // In ra danh sach cac quyen sach tang dan theo gia
        /* Sort Increase */
        private void SortPriceIncrease()
        {
            books.Sort
                    (delegate (Book b1, Book b2)
                {
                    return b1.Price.CompareTo(b2.Price);
                });
        }
        public void Display(List<Book> books)
        {
            
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5}",
                  "ID", "Title", "Author", "Publisher", "Year", "Price");

            if (books != null && books.Count > 0)
            {
                SortPriceIncrease();
                foreach (Book bk in books)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5}",
                                      bk.Id, bk.Title, bk.Author, bk.Publisher, bk.Year, bk.Price);
                }
            }
            Console.WriteLine();
        }

        public List<Book> GetListBook()
        {
            return books;
        }

        // Find by Title
        public List<Book> findByName(string search)
        {

            List<Book> searchResult = new List<Book>();
            if (books != null && books.Count > 0)
            {
                foreach (Book sv in books)
                {
                    if (sv.Title.Contains(search))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }

        // find by Title 2


        // Print all book in year 2014
        public void Display2014(List<Book> books)
        {
             Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5}",
                  "ID", "Title", "Author", "Publisher", "Year", "Price");

            if (books != null && books.Count > 0 )
            {
                
                foreach (Book bk in books)
                {
                    if (bk.Year.Equals("2014"))
                    {
                        Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5}",
                                    bk.Id, bk.Title, bk.Author, bk.Publisher, bk.Year, bk.Price);
                    }
                  
                }
            }
            Console.WriteLine();
        }

        // Xoa sach  theo ten
        
        public bool DeleteByName(string search)
        {
            bool IsDeleted = false;
            // tìm kiếm sinh viên theo ID
            Book book = new Book(); 
            book.Publisher = search;
            if (book != null)
            {
                IsDeleted = books.Remove(book);
            }
            return IsDeleted;
        }
    }
}
