using StudentSys.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.BLL
{
    public class EmployeeManager
    {
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="pwd"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool Login(string mail, string pwd, out Guid userId)
        {
            
            using (var employee = new EmployeeService())
            {
                var emp = employee.GetAll(item => item.Email == mail && item.Password == pwd).FirstOrDefaultAsync();
                emp.Wait();
                if (emp.Result == null)
                {
                    userId = Guid.Empty;
                    return false;
                }
                else
                {
                    userId = emp.Result.Id;
                    return true;
                }
            }
        }
        /// <summary>
        /// 创建职工
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="pwd"></param>
        /// <param name="phone"></param>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static async Task CreateEmployee(string mail, string pwd, string phone, Guid typeId)
        {
            using (var emp = new EmployeeService())
            {
                 await emp.CreateAsync(new Models.Employee()
                {
                    Email = mail,
                    EmployeeTypeId = typeId,
                    Phone = phone,
                    Password = pwd
                });
            }
        }
    }
}
