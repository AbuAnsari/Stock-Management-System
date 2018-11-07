
using StockManagementApplication.Models;
using System;
using System.Data.SqlClient;

namespace StockManagementApplication.DAL
{
    public class StockInRepository
    {
        private readonly string _connectionString = GenericRepository.ConnectionString();
        readonly GenericRepository _genericRepository = new GenericRepository();

        public bool Save(StockIn stock)
        {
            try
            {
                var query = "INSERT INTO Stocks(CategoryId, CompanyId, ItemId, InQuantity, ReceiveDate, CreateBy, CreateDate) VALUES(" +
                    stock.CategoryId + "," +
                    "" + stock.CompanyId + ", " + stock.ItemId + ", " + stock.Quantity + ",'" + stock.ReceiveDate +
                    "', '" + stock.CreateBy + "','" + stock.CreateDate + "')";
                var rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public SqlDataReader GetAvaialableQtyByItemId(StockIn stock)
        {
            try
            {
                var query = "SELECT SUM(s.InQuantity) AS InQuantity FROM Stocks s WHERE s.ItemId= " + stock.ItemId + "";
                var reader = _genericRepository.ExecuteReader(query, _connectionString);
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
