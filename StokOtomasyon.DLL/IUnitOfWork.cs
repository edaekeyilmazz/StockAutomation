using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokOtomasyon.DLL.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<Stok, Guid> StokRep { get; }
        IGenericRepository<Hareket, Guid> HareketRep { get; }
        IGenericRepository<Depo, Guid> DepoRep { get; }
        bool SaveChanges();
        
    }
}
