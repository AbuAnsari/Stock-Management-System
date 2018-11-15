using StockManagementApplication.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace StockManagementApplication.DAL
{
    public class ItemRepository
    {
        private readonly string _connectionString = GenericRepository.ConnectionString();
        readonly GenericRepository _genericRepository = new GenericRepository();

        public bool Save(Item item)
        {
            try
            {
                string query = "INSERT INTO Items(CategoryId, CompanyId, Name,ReorderLevel, CreateBy, CreateDate) VALUES('" + item.CategoryId + "'," +
                               "'" + item.CompanyId + "', '" + item.Name + "', '" + item.ReorderLevel + "','" + item.CreateBy + "','" + item.CreateDate + "')";
                var rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Item IsNameExist(string name)
        {
            try
            {
                var query = "SELECT * FROM Items WHERE Name='" + name + "'";
                var reader = _genericRepository.ExecuteReader(query, _connectionString);
                if (reader.HasRows)
                {
                    reader.Read();
                    var item = new Item()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        CategoryId = Convert.ToInt32(reader["CategoryId"]),
                        CompanyId = Convert.ToInt32(reader["CompanyId"]),
                        Name = reader["Name"].ToString(),
                        ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]),
                        CreateBy = reader["CreateBy"].ToString(),
                        CreateDate = Convert.ToDateTime(reader["CreateDate"])
                    };
                    return item;
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public DataTable GetAllCompanyByCategoryId(Item item)
        {
            try
            {
                var query = "SELECT DISTINCT c.Id, c.Name FROM Items i INNER JOIN Companies c On c.Id= i.CompanyId WHERE CategoryId=" + item.CategoryId + "";
                var dataAdapter = _genericRepository.ExecuteAdapter(query, _connectionString);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public DataTable GetAllItemByCompanyId(Item item)
        {
            try
            {
                var query = "SELECT Id, Name FROM Items WHERE CompanyId= " + item.CompanyId + "";
                var dataAdapter = _genericRepository.ExecuteAdapter(query, _connectionString);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataReader GetReorderLevel(Item item)
        {
            try
            {
                var query = "SELECT ReorderLevel FROM Items WHERE Id= " + item.Id + "";
                var reader = _genericRepository.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public DataTable GetItemReport(int? categoryId, int? companyId)
        {
            try
            {
                var query =
                    "SELECT i.Name AS ItemName, co.Name AS CompanyName, c.Name AS CategoryName, i.ReorderLevel, ISNULL(ISNULL(SUM(s.InQuantity),0)-ISNULL(SUM(s.OutQuantity),0),0) AS AvailableQty FROM Items i " +
                    "LEFT JOIN Categories c ON c.Id= i.CategoryId " +
                    "LEFT JOIN Companies co ON co.Id= i.CompanyId " +
                    "LEFT JOIN Stocks s ON i.Id= s.ItemId WHERE ";
                if (companyId > 0 && categoryId > 0)
                {
                    query += " i.CategoryId=" + categoryId + " AND i.CompanyId=" + companyId;
                }
                else if (categoryId > 0)
                    query += " i.CategoryId=" + categoryId;

                else if (companyId > 0)
                    query += " i.CompanyId=" + companyId;



                query += " GROUP BY i.Name,c.Name, co.Name, i.ReorderLevel";
                var dataAdapter = _genericRepository.ExecuteAdapter(query, _connectionString);
                var dataTable = new DataTable();
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
