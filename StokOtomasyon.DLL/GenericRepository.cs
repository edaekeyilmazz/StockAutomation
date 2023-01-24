using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace StokOtomasyon.DLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T, Guid> 
        where T: class
    {
        protected StokOtomasyonContext _context;
        protected DbSet<T> db;
        public GenericRepository(StokOtomasyonContext context)
        {
            this._context = context;
            db = context.Set<T>();
        }

        public IQueryable<T> GetByFilter(System.Linq.Expressions.Expression<Func<T, bool>> filter, params string[] Includes)
        {
            foreach (var item in Includes)
                db.Include(item);
            return db.Where(filter);
        }

        IList<T> IGenericRepository<T, Guid>.GetByFilter(Dictionary<string, object> filter)
        {
            throw new NotImplementedException();
        }
        public IList<T> GetAll()
        {
            return db.ToList();
        }

        public T GetById(Guid prmId)
        {
            return db.Find(prmId);
        }

        public void Insert(T ent)
        {
            db.Add(ent);
            _context.Entry<T>(ent).State=EntityState.Added;
        }

        public void Update(T ent)
        {
            db.Attach(ent);
            _context.Entry<T>(ent).State = EntityState.Modified;
        }

        public void Delete(Guid prmId)
        {
            db.Remove(db.Find(prmId));
        }
       

    }
}
