using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{       
    /// <summary>
    /// 学生亲属
    /// </summary>
    public class StudentRelative : BaseEntity
    {

        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TypeName { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
