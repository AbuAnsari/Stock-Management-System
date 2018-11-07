using StockManagementApplication.Models;
using System;
using System.Data;

namespace StockManagementApplication.DAL
{
    public class CompanyRepository
    {
        private readonly string _connectionString = GenericRepository.ConnectionString();
        readonly GenericRepository _genericRepository = new GenericRepository();

        public bool Save(Company company)
        {
            try
            {
                var query = "INSERT INTO Companies VALUES('" + company.Name + "', '" + company.CreateBy + "','" +
                            company.CreateDate + "')";
                var rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool IsNameExist(Company company)
        {
            try
            {
                var query = "SELECT * FROM Companies WHERE Name='" + company.Name + "'";
                var reader = _genericRepository.ExecuteReader(query, _connectionString);
                return reader.HasRows;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable GetAll()
        {
            try
            {
                string query = "SELECT * FROM Companies";
                var dataAdapter = _genericRepository.ExecuteAdapter(query, _connectionString);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
