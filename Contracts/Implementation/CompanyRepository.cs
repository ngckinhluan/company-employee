using Contracts.Interfaces;
using Entities.Models;
using Repository;

namespace Contracts.Implementation
{
    public class CompanyRepository(RepositoryContext context) : RepositoryBase<Company>(context), ICompanyRepository
    {
        public IEnumerable<Company> GetAllCompanies(bool trackChanges) => FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

    }
}
