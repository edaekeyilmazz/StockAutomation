using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokOtomasyon.DLL.Repositories
{
    public class HareketRepository : GenericRepository<Hareket>
    {
        public HareketRepository(StokOtomasyonContext _context) : base(_context)
        {
        }
    }
}
