using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace Library.Models
{
   public class Management
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public Person Person { get; set; }

        [Required]
        public Book Book { get; set; }

        [Required]
        public System.Nullable<DateTime> BookReturnDate { get; set; }
        [Required]
        public bool returned { get; set; }
    }
}
