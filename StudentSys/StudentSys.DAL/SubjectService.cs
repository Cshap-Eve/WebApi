using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class SubjectService : BaseService<Models.Subject>
    {
        public SubjectService() : base(new Models.StudentContext())
        {

        }
    }
}
