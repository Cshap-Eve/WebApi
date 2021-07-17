using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class StudentLanCompleteService : BaseService<Models.StudentLanComplete>
    {
        public StudentLanCompleteService() : base(new Models.StudentContext())
        {
        }
    }
}
