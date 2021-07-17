using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.Models
{
    public class SysSetting : BaseEntity
    {
        public int JobScore { get; set; }
        public int CompleteScore { get; set; }
        public int ExamScore { get; set; }
        public int TeiggerScore { get; set; }
    }
}
