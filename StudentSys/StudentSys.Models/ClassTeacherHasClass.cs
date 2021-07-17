using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    public class ClassTeacherHasClass:BaseEntity
    {
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey(nameof(Class))]
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
    }
}
