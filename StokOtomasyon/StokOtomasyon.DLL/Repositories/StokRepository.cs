using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokOtomasyon.DLL.Repositories
{
    public class StokRepository : GenericRepository<Stok>
    {
        public StokRepository(StokOtomasyonContext _context) : base(_context)
        {
        }
    }
}
