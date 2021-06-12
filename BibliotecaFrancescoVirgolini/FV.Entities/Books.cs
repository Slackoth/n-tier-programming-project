using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV.Entities
{
    public class Books
    {
        public int BooksId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Editorial { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Subject { get; set; }
    }
}
