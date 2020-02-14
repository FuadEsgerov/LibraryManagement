using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Library.Models
{
   public class Purchase
    {

        [Key]
        public int PurchaseID { get; set; }

        [Required]
        public Management Management { get; set; }

        [Required]
        public float Money { get; set; }

        [Required]
        public System.Nullable<DateTime> BookReturnededDate { get; set; }
    }
}
