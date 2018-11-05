using StockManagementApplication.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StockManagementApplication.DAL
{
    public class CategoryRepository
    {
        private readonly string _connectionString = GenericRepository.ConnectionString();
        readonly GenericRepository _genericRepository = new GenericRepository();

        public bool Save(Category category)
        {
            try
            {
                var query = "INSERT INTO Categories(Name, CreateBy, CreateDate) VALUES('" + category.Name + "','" + category.CreateBy + "', '" + category.CreateDate + "')";
                var rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool IsNameExist(Category category)
        {
            try
            {
                var query = "SELECT * FROM Categories WHERE Name='" + category.Name + "'";
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
                var query = "SELECT Id, Name FROM Categories";
                SqlDataAdapter dataAdapter = _genericRepository.ExecuteAdapter(query, _connectionString);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool Update(Category category)
        {
            try
            {
                var query = "UPDATE Categories SET Name='" + category.Name + "', UpdateBy='" + category.UpdateBy +"', UpdateDate='" + category.UpdateDate + "'" +
                            " WHERE Id='"+category.Id+"'";
                var rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
