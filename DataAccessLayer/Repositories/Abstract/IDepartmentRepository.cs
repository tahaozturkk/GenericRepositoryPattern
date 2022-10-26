﻿using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Abstract
{
    public interface IDepartmentRepository: IGenericRepository<Department>
    {
        List<Department> GetDepartmentsWithPersonnels();
    }
}
