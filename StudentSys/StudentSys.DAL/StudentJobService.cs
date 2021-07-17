using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class StudentJobService : BaseService<Models.StudentJob>
    {
        public StudentJobService() : base(new Models.StudentContext())
        {

        }
    }
}
