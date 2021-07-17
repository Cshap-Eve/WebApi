using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
   public class Score:BaseEntity
    {
        [ForeignKey(nameof(Subject))]
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        public int ExamScore { get; set; }

    }
}
