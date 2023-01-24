using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokOtomasyon.DLL.Repositories
{
    public class DepoRepository : GenericRepository<Depo>
    {
        public DepoRepository(StokOtomasyonContext _context) : base(_context)
        {
        }
    }
}
