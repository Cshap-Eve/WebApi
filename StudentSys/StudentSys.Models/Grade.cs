using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
  public  class Grade:BaseEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
