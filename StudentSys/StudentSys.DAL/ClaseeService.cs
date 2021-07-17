using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class ClaseeService : BaseService<Models.Class>
    {
        public ClaseeService() : base(new Models.StudentContext())
        {

        }

        public async Task ChangeName(Guid id, string clsName)
        {
            var cls = new Models.Class() { Id = id };
            _db.Entry(cls).State = EntityState.Unchanged;
            cls.Name = clsName;
            await SaveAsync();
        }

        public async Task ChangeGrate(Guid id, Guid gradeId)
        {
            var cls = new Models.Class() { Id = id };
            _db.Entry(cls).State = EntityState.Unchanged;
            cls.GradeId = gradeId;
            await SaveAsync();
        }
        public async Task Gradution(Guid id)
        {
            var cls = new Models.Class() { Id = id };
            _db.Entry(cls).State = EntityState.Unchanged;
            cls.IsGraduation = true;
            await SaveAsync();
        }
    }
}
