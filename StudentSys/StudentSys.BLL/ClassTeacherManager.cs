using StudentSys.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.BLL
{
    public class ClassTeacherManager
    {
        /// <summary>
        /// 创建班级
        /// </summary>
        /// <param name="clasaName"></param>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public static async Task CreateClass(string clasaName, Guid gradeId)
        {
            using (var cls = new ClaseeService())
            {
                await cls.CreateAsync(new Models.Class()
                {
                    GradeId = gradeId,
                    Name = clasaName
                });
            }
        }

        /// <summary>
        /// 修改班级
        /// </summary>
        /// <param name="clsId"></param>
        /// <param name="clsName"></param>
        /// <returns></returns>
        public static async Task ChangeClassName(Guid clsId, string clsName)
        {
            using (var cls = new ClaseeService())
            {
                await cls.ChangeName(clsId, clsName);
            }
        }

        /// <summary>
        /// 升学
        /// </summary>
        /// <param name="clsId"></param>
        /// <returns></returns>
        public static async Task LeaveUpClass(Guid clsId)
        {
            using (var cls = new ClaseeService())
            {
                var result = await cls.GetOne(clsId);
                using (var gra = new GradeService())
                {
                    var grade = await gra.GetAll(item => item.Order > result.Grade.Order).FirstOrDefaultAsync();
                    if (grade == null)
                    {
                        await Gradution(clsId);
                        return;
                    }
                    await cls.ChangeGrate(clsId, grade.Id);
                }
            }
        }

        /// <summary>
        /// 毕业
        /// </summary>
        /// <param name="clsId"></param>
        /// <returns></returns>
        public static async Task Gradution(Guid clsId) 
        {
            using (var cls = new ClaseeService())
            {
                await cls.Gradution(clsId);
            }
        }
    }
}
