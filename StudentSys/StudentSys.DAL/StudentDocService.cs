using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class StudentDocService : BaseService<Models.StudentDoc>
    {
        public StudentDocService() : base(new Models.StudentContext())
        {

        }
    }
}
