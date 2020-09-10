using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksReadApp.Models
{
    public class BooksReadContext : DbContext
    {
        public BooksReadContext() : base("BookContext")
            {
            }
        public DbSet<Book> Books { get; set; }
    }
}
