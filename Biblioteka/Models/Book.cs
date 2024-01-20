using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int QNT { get; set; }
        public int LibraryId { get; set; }


        public override string ToString()
        {
            return $"id: {Id} - Name: {Name} - Author: {Author} - QNT: {QNT} - CategoryId: {LibraryId}";
        }
    }
}
