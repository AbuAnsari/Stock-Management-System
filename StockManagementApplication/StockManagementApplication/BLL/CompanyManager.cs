using StockManagementApplication.DAL;
using StockManagementApplication.Models;

namespace StockManagementApplication.BLL
{
    public class CompanyManager
    {
        readonly CompanyRepository _companyRepository = new CompanyRepository();

        public bool Save(Company company)
        {
            var save = _companyRepository.Save(company);
            return save;
        }
    }
}
