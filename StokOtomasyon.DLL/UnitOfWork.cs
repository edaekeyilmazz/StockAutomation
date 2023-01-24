using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokOtomasyon.DLL.Repositories
{

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        StokOtomasyonContext context;
        public UnitOfWork ()
	    {
            context = new StokOtomasyonContext();
	    }


        StokRepository _stokRep;
        public IGenericRepository<Stok, Guid> StokRep
        {
            get
            {
                if (_stokRep == null) _stokRep = new StokRepository(context);
                return _stokRep;
            }
        }

        HareketRepository _hareketRep;
        public IGenericRepository<Hareket, Guid> HareketRep
        {
            get
            {
                if (_hareketRep == null) _hareketRep = new HareketRepository(context);
                return _hareketRep;
            }
        }


        DepoRepository _depoRep;
        public IGenericRepository<Depo, Guid> DepoRep
        {
            get
            {
                if (_depoRep == null) _depoRep = new DepoRepository(context);
                return _depoRep;
            }
        }

        public bool SaveChanges()
        {
            return (context.SaveChanges() > 0);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
