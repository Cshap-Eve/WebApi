using StudentSys.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentSys.DAL
{
    public class BaseService<T> : IDisposable where T : BaseEntity, new()
    {
        protected readonly StudentContext _db;
        public BaseService(StudentContext db)
        {
            _db = db;
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task CreateAsync(T t, bool saved = true)
        {
            _db.Set<T>().Add(t);
            if (saved)
                await SaveAsync();
        }

        public async Task SaveAsync(bool isValid = true)
        {
            if (isValid)
            {
                _db.Configuration.ValidateOnSaveEnabled = false;
                await _db.SaveChangesAsync();
                _db.Configuration.ValidateOnSaveEnabled = true;
                return;
            }
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(T t, bool saved = true)
        {
            _db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            if (true)
                await SaveAsync();
        }

        public async Task Remove(Guid id, bool saved = true)
        {
            T t = new T()
            {
                Id = id
            };
            _db.Entry(t).State = System.Data.Entity.EntityState.Unchanged;
            t.IsRemove = true;
            if (saved)
                await SaveAsync();
        }

        public async Task<T> GetOne(Guid id)
        {
            return await GetAll().FirstOrDefaultAsync(item => item.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>().AsNoTracking().Where(item => !item.IsRemove);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate, bool asc = true) 
        {
            var data = GetAll(predicate);
            if (asc)
                return data.OrderBy(item => item.CreateTime);
            return data.OrderByDescending(item => item.CreateTime);
        }
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate, bool asc, int pageIndex=1, int pageSize=10)
        {
            return GetAll(predicate, asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

    }
}
