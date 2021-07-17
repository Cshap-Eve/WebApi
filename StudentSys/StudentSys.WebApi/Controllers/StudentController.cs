using StudentSys.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace StudentSys.WebApi.Controllers
{
    /*
      1，引用ef
    */
    public class StudentController : ApiController
    {

        private readonly StudentManager _studentManager;
        private readonly EmployeeManager _employeeManager;
        private readonly ClassTeacherManager _classTeacherManager;
        public StudentController() 
        {
            _studentManager = new StudentManager();
            _employeeManager = new EmployeeManager();
            _classTeacherManager = new ClassTeacherManager();
        }

        [HttpPost]
        public async Task GetStudent() 
        {
       
        }
    }
}
