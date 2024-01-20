using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.Models
{
    internal class Library
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Book> BookList { get; set; }


        public override string ToString()
        {
            return $"id: {Id} - CategoryName: {CategoryName}";
        }
    }
}
