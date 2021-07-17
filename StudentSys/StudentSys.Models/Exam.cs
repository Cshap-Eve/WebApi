using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
   public class Exam:BaseEntity
    {
        [ForeignKey(nameof(Class))]
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
        public DateTime ExamTime { get; set; }
        [ForeignKey(nameof(Subject))]
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
