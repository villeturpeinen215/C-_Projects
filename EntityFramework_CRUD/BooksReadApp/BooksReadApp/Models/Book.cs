using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksReadApp.Models
{
    public class Book
    {
        //get items from Book table
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public string Publisher { get; set; }
        public string Publication_date { get; set; }

    }
}
