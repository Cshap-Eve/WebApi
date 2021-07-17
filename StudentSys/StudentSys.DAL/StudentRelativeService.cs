using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class StudentRelativeService : BaseService<Models.StudentRelative>
    {
        public StudentRelativeService() : base(new Models.StudentContext())
        {
        }
    }
}
