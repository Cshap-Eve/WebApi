using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
   public class StudentSignedService : BaseService<Models.StudentSigned>
    {
        public StudentSignedService() : base(new Models.StudentContext())
        {
        }
    }
}
