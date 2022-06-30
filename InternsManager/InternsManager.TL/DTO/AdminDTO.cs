using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsManager.TL.DTO
{
    public class AdminDTO
    {
        public int IdAdmin { get; set; }

        public int IdPerson { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
