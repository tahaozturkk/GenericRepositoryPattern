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
    public class PersonnelRepository : GenericRepository<Personnel>, IPersonnelsRepository
    {
        public PersonnelRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Personnel> GetPersonnelsWithDepartments()
        {
            return DatabaseContext.Personnels.Include(x => x.Department).ToList();
        }
        public DatabaseContext DatabaseContext { get { return _context as DatabaseContext; } }
    }
}
