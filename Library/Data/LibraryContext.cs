using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using System.Data.Entity;

namespace Library.Data
{
    public class LibraryContext :DbContext
    {
         public LibraryContext() : base("LibraryContext")
        {
            

        }
        public DbSet<User> User { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Management> Management { get; set; }

         public DbSet<Purchase> Purchase { get; set; }
    }
}
