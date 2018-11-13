using StockManagementApplication.DAL;
using StockManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;

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
        public bool IsNameExist(Company company)
        {
            var isExist = _companyRepository.IsNameExist(company);
            return isExist;
        }

        public List<Company> GetAll()
        {
            DataTable dataTable = _companyRepository.GetAll();
            var companies = new List<Company>();
            var serial = 1;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                var company = new Company();
                company.Id = Convert.ToInt32(dataRow["Id"]);
                company.SerialNo = serial;
                company.Name = dataRow["Name"].ToString();
                company.CreateBy = dataRow["CreateBy"].ToString();
                company.CreateDate = Convert.ToDateTime(dataRow["CreateDate"]);

                companies.Add(company);
                serial++;
            }

            return companies;
        }
    }
}
