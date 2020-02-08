﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Library.Models
{
    class Book
    {
        [Key]
        public int bookID { get; set; }

        [Required]
        [MaxLength(50)]
        public string bookName { get; set; }
         [Required]
         [MaxLength(50)]
        public string bookGenre { get; set; }
         [Required]
        public float bookPrice { get; set; }
    }
}
