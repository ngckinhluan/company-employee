using Contracts.Interfaces;
using Entities.Models;
using Repository;

namespace Contracts.Implementation
{
    public class EmployeeRepository(RepositoryContext context) : RepositoryBase<Employee>(context), IEmployeeRepository
    {
        public IEnumerable<Employee> GetAllEmployees(Guid companyId, bool trackChanges) =>
            FindByCondition(e => e.CompanyId.Equals(companyId), trackChanges)
                .OrderBy(e => e.Name).ToList();

        public Employee GetEmployee(Guid companyId, Guid id, bool trackChanges) =>
            FindByCondition(e => e.CompanyId.Equals(companyId) && e.Id.Equals(id),
                    trackChanges)
                .SingleOrDefault();

    }
}
