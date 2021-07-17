using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    public class EmployeeType : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
