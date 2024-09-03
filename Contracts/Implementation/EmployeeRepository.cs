using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Interfaces;
using Entities.Models;
using Repository;

namespace Contracts.Implementation
{
    public class EmployeeRepository(RepositoryContext context) : RepositoryBase<Employee>(context), IEmployeeRepository
    {
    }
}
