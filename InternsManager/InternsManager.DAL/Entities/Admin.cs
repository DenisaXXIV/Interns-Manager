using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsManager.DAL.Entities
{
    public class Admin
    {
        [Required]
        [Key]
        public int IdAdmin { get; set; }

        [Required(ErrorMessage = "*** Person Err ***")]
        [ForeignKey("Person")]
        public int IdPerson { get; set; }

        [Required(ErrorMessage = "*** Username Err ***")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*** Password Err ***")]
        public string Password { get; set; }
    }
}
