using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Abstract
{
    public interface IPersonnelsRepository: IGenericRepository<Personnel>
    {
        IEnumerable<Personnel> GetPersonnelsWithDepartments();
    }
}
