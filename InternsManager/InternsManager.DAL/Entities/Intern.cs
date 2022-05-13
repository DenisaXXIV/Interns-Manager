using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsManager.DAL.Entities
{
    public class Intern
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*** Name Err ***")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*** Age Err ***")]
        public int Age { get; set; }

        [Required(ErrorMessage = "*** Date of Birth Err ***")]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "*** Gender Err ***")]
        public string Gender { get; set; }
        public string? PicPath { get; set; }
    }
}
