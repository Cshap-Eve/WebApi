using StudentSys.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.BLL
{
    public class StudentManager
    {
        public static async Task CreateStudent(string name, Guid? classId, string imagePath, string Email, string QQ,
            string phone, DateTime bornTime, string sex)
        {
            using (var stuSer = new StudentService())
            {
                await stuSer.CreateAsync(new Models.Student()
                {
                    Name = name,
                    Email = Email,
                    ImagePath = imagePath,
                    Phone = phone,
                    QQ = QQ,
                    Sex = sex,
                    BronDate = bornTime,
                    ClassId = classId,
                });

            }
        }
    }
}
