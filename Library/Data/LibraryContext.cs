using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using System.Data.Entity;

namespace Library.Data
{
    class LibraryContext :DbContext
    {
         public LibraryContext() : base(@"Server=DELL-PC\SQLEXPRESS;Database=LibraryManagement;Trusted_Connection=True;")
        {
            

        }
         public DbSet<Book> Books { get; set; }
         public DbSet<User> Users { get; set; }
         public DbSet<Management> Managements { get; set; }

         public DbSet<Purchase> Purchases { get; set; }
    }
}
