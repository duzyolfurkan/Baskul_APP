using DataAccess.Context;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class GunlukOgunYorumlariRepository : BaseRepository<GunlukOgunYorumlari>
    {
        public GunlukOgunYorumlariRepository(BaskulAppDbContext baskulAppDbContext) : base(baskulAppDbContext)
        {
        }
    }
}
