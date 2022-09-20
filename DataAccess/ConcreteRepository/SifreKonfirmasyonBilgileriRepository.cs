using DataAccess.Context;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class SifreKonfirmasyonBilgileriRepository : BaseRepository<SifreKonfirmasyonBilgileri>
    {
        public SifreKonfirmasyonBilgileriRepository(BaskulAppDbContext baskulAppDbContext) : base(baskulAppDbContext)
        {
        }
    }
}
