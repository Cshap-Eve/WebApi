using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class ExamService : BaseService<Models.Exam>
    {
        public ExamService() : base(new Models.StudentContext())
        {

        }
    }
}
