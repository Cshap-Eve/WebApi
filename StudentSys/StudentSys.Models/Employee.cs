using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    public class Employee : BaseEntity
    {
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        [ForeignKey(nameof(EmployeeType))]
        public Guid EmployeeTypeId { get; set; }
        public EmployeeType EmployeeType { get; set; }

    }
}
