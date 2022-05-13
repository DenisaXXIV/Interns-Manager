using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsManager.TL.DTO
{
    public class InternDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PicPath { get; set; }

        public override string ToString()
        {
            return Name + "( " + Age + ")";
        }
    }
}
