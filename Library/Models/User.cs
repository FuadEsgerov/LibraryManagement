using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Library.Models
{
    public enum UserLevel
    {
        Admin,
        Moderator
    }
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public bool Status { get; set; }
        [Required]
        [MaxLength(50)]

        public string Fullname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        public UserLevel Level { get; set; }
    }
}
