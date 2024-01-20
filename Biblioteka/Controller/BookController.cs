using Biblioteka.Data;
using Biblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.Controller
{
    internal class BookController
    {

        public static void GetOneBook(int id)
        {
            var _context = new LibraryDbContext();

            var book= _context.Books.FirstOrDefault(x => x.Id == id);

            Console.WriteLine(book);
        }

        public static void GetAllBook()
        {
            int count = 5;
            LibraryController.Pagination(count);
            string manage = "";
            while (manage != "2")
            {
                Console.WriteLine("1.More");
                Console.WriteLine("2.exit");

                manage = Console.ReadLine();

                if(manage == "1")
                {
                    count += 5;
                    LibraryController.Pagination(count);
                }
            }

        }


        public static Book AddBook()
        {
            var _context = new LibraryDbContext();
            Book book;

            _context.Books.Add(book = new Book()
            {
                Name = Console.ReadLine(),
                Author = Console.ReadLine(),
                QNT = int.Parse(Console.ReadLine()),
                LibraryId = int.Parse(Console.ReadLine()),
            });

            _context.SaveChanges();

            return book;
        }

        public static Book UpdateBook(int id)
        {
            var _context = new LibraryDbContext();

            var bookForUpdate = _context.Books.FirstOrDefault(x => x.Id == id);

            Console.WriteLine("Enter new Book Name: ");
            bookForUpdate.Name = Console.ReadLine();

            Console.WriteLine("Enter new Book Author: ");
            bookForUpdate.Author = Console.ReadLine();

            Console.WriteLine("Enter new Book Quantity: ");
            bookForUpdate.QNT = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Book Category: ");
            bookForUpdate.LibraryId = int.Parse(Console.ReadLine());

            _context.SaveChanges();
            return bookForUpdate;

        }


        public static void DeleteBook(int id)
        {
            var _context = new LibraryDbContext();

            var bookForDelete = _context.Books.FirstOrDefault(x => x.Id == id);

            _context.Books.Remove(bookForDelete);

            _context.SaveChanges();
        }


    }
}
