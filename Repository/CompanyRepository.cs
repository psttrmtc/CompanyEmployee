using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Company> getAllCompanies(bool trackChanges)
        => FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
        public Company GetCompany(Guid comnpanyId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(comnpanyId), trackChanges).SingleOrDefault();
    }
}
