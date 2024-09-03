using Contracts.Interface;
using Entities.Models;
using Repository;

namespace Contracts.Implementation
{
    public class CompanyRepository(RepositoryContext context) : RepositoryBase<Company>(context), ICompanyRepository;
}
