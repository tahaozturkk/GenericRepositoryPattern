using DataAccessLayer.Repositories.Abstract;
using Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concrete
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        
        public DepartmentRepository(DbContext context) : base(context)
        {
            
        }

        public IEnumerable<Department> GetDepartmentsWithPersonnels()
        {
            return DatabaseContext.Departments.Include(x => x.Personnels).ToList();
        }
        public DatabaseContext DatabaseContext { get { return _context as DatabaseContext; } }
    }
}
