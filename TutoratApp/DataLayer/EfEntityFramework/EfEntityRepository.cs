using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfEntityFramework
{
    class EfEntityRepository<T> : IEntityRepository<T> where T : Entity
    {
        private readonly TutoringDbContext _context;

        public EfEntityRepository()
        {
            _context = new TutoringDbContext();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }


        public T GetById(int id)
        {
            return _context.Set<T>().ElementAt<T>(id);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
    }
}
