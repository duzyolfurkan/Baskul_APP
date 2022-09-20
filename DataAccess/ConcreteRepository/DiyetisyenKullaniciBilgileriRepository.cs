using DataAccess.Context;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class DiyetisyenKullaniciBilgileriRepository : BaseRepository<DiyetisyenKullaniciBilgileri>
    {
        public DiyetisyenKullaniciBilgileriRepository(BaskulAppDbContext baskulAppDbContext) : base(baskulAppDbContext)
        {

        }
    }
}
