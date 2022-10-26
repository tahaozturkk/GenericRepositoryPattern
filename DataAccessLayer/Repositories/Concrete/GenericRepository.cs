using DataAccessLayer.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        readonly DbContext _context;
        private DbSet<T> _dbset;
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbset.Find(id);
        }

        public List<T> GetListAll()
        {
            return _dbset.ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
