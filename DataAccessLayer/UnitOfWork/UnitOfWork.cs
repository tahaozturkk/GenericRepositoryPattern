using DataAccessLayer.Repositories.Abstract;
using DataAccessLayer.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            DeparmentRepository = new DepartmentRepository(_context);
            PersonnelsRepository = new PersonnelRepository(_context);
        }

        public IDepartmentRepository DeparmentRepository { get; private set; }

        public IPersonnelsRepository PersonnelsRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
