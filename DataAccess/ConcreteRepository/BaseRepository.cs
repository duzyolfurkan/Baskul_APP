using DataAccess.Context;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class BaseRepository<T> where T : class, IBaseEntity
    {
        private readonly BaskulAppDbContext _baskulAppDbContext;
        private DbSet<T> _table;

        public BaseRepository(BaskulAppDbContext baskulAppDbContext)
        {
            _baskulAppDbContext = baskulAppDbContext;
            _table = _baskulAppDbContext.Set<T>();
        }

        public bool Ekle(T entity)
        {
            _table.Add(entity);
            return Kaydet() > 0;
        }

        public bool Sil(T entity)
        {
            entity.Status = Status.Deleted;
            return Guncelle(entity);
        }

        public bool Guncelle(T entity)
        {
            _baskulAppDbContext.Entry<T>(entity).State = EntityState.Modified;
            return Kaydet() > 0;
        }

        public T IdyeGoreGoruntule(int id)
        {
            return _table.Find(id);
        }

        public List<T> TumunuGoruntule()
        {
            return _table.Where(x => x.Status == Status.Active || x.Status == Status.Modified).ToList();
        }


        public int Kaydet()
        {
            return _baskulAppDbContext.SaveChanges();
        }
    }
}
