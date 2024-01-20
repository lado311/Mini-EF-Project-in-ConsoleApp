using Biblioteka.Data;
using Biblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.Controller
{
    internal class LibraryController
    {
        public static void Pagination(int count)
        {
            var _context = new LibraryDbContext();

            var allBook = _context.Books.Take(count);

            foreach (var item in allBook)
            {
                Console.WriteLine(item);    
            }

            
        }

        public static void GetAllLibrarysCategory()
        {
            var _context = new LibraryDbContext();

            foreach (var item in _context.Libraries)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetBookByCategory(int id)
        {
            var _context = new LibraryDbContext();

            var LibrarysCategory = _context.Libraries.FirstOrDefault(l => l.Id == id);

            foreach (var item in _context.Books)
            {
                if(item.LibraryId == LibrarysCategory.Id)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
