using DataAccess.Context;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class SuIcmeVeriGirisleriRepository : BaseRepository<SuIcmeVeriGirisleri>
    {
        public SuIcmeVeriGirisleriRepository(BaskulAppDbContext baskulAppDbContext) : base(baskulAppDbContext)
        {

        }
    }
}
