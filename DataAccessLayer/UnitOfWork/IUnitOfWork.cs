using DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository DeparmentRepository { get; }
        IPersonnelsRepository PersonnelsRepository { get; }
        int Complete();
    }
}
