using Contracts.Interfaces;
using Entities.Models;
using Repository;

namespace Contracts.Implementation
{
    public class EmployeeRepository(RepositoryContext context) : RepositoryBase<Employee>(context), IEmployeeRepository
    {
    }
}
