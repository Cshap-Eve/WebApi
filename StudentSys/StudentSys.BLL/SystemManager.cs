using StudentSys.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.BLL
{
    public class SystemManager
    {
        /// <summary>
        /// 创建年级
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task CreateGrade(string name)
        {
            using (var grade = new GradeService())
            {

                var maxOrder = await grade.GetAll().MaxAsync(item => item.Order);
                await grade.CreateAsync(new Models.Grade()
                {
                    Name = name,
                    Order = maxOrder + 1
                });
            }
        }
        /// <summary>
        /// 上移年级
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public static async Task GradeUp(Guid gradeId)
        {
            using (var gradesSer = new GradeService())
            {
                var grade = await gradesSer.GetOne(gradeId);
                var orderBefor = await gradesSer.GetAll(item => item.Order > grade.Order).FirstOrDefaultAsync();
                if (orderBefor == null) return;
                await gradesSer.ChangeOrder(gradeId, orderBefor.Order, false);
                await gradesSer.ChangeOrder(orderBefor.Id, grade.Order);
            }


        }
        /// <summary>
        /// 下移年级
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public static async Task GradeDown(Guid gradeId)
        {
            using (var gradesSer = new GradeService())
            {
                var grade = await gradesSer.GetOne(gradeId);
                var orderBefor = await gradesSer.GetAll(item => item.Order < grade.Order).FirstOrDefaultAsync();
                if (orderBefor == null) return;
                await gradesSer.ChangeOrder(gradeId, orderBefor.Order, false);
                await gradesSer.ChangeOrder(orderBefor.Id, grade.Order);
            }
        }
        /// <summary>
        /// 修改年级名称
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task ChangeName(Guid id, string name)
        {
            using (var gradesSer = new GradeService())
            {
                await gradesSer.ChangeName(id, name);
            }
        }
        /// <summary>
        /// 创建科目
        /// </summary>
        /// <param name="gradeId"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task CreateSubject(Guid gradeId, string name)
        {
            using (var subSer = new SubjectService())
            {
                await subSer.CreateAsync(new Models.Subject()
                {
                    Name = name,
                    GradeId = gradeId,
                });
            }
        }
        /// <summary>
        /// 修改科目
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gradeId"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static async Task EditSubjec(Guid id, Guid gradeId, string name)
        {
            using (var subSer = new SubjectService())
            {
                await subSer.EditAsync(new Models.Subject()
                {
                    GradeId = gradeId,
                    Id = id,
                    Name = name
                });
            }
        }

    }
}
