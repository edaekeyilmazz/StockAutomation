using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StokOtomasyon.DLL.Repositories
{
    public interface IGenericRepository<T, K>
        where T : class
        where K : struct
    {
        IList<T> GetAll();
        T GetById(K prmId);
        void Insert(T ent);
        void Update(T ent);
        void Delete(K prmId);
        IQueryable<T> GetByFilter(Expression<Func<T, bool>> filter, params string[] Includes);
        IList<T> GetByFilter(Dictionary<string, object> filter);
    }


}
