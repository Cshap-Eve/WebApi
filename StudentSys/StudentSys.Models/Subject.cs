using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
   public class Subject:BaseEntity
    {
        [Required]
        public Guid GradeId { get; set; }
        public Grade Grade { get; set; }
        public string Name { get; set; }
    }
}
