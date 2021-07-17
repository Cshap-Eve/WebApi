using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class EmployeeService : BaseService<Models.Employee>
    {
        public EmployeeService() : base(new Models.StudentContext())
        {
        }
    }
}
