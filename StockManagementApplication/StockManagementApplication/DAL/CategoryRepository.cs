using StockManagementApplication.Models;
using System;

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
                var query = "INSERT INTO Categories VALUES('" + category.Name + "','" + category.CreateBy + "', '" + category.CreateDate + "')";
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
