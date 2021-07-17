using StudentSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class GradeService : BaseService<Models.Grade>
    {
        public GradeService() : base(new Models.StudentContext())
        {

        }

        public async Task ChangeOrder(Guid id, int order, bool isSaved = true)
        {
            var model = new Grade() { Id = id };
            _db.Entry(model).State = System.Data.Entity.EntityState.Unchanged;
            model.Order = order;
            if (isSaved)
            {
                await SaveAsync();
            }
        }
        public async Task ChangeName(Guid id, string name, bool isSaved = true)
        {
            var model = new Grade() { Id = id };
            _db.Entry(model).State = System.Data.Entity.EntityState.Unchanged;
            model.Name = name;
            if (isSaved)
            {
                await SaveAsync();
            }
        }
    }
}
