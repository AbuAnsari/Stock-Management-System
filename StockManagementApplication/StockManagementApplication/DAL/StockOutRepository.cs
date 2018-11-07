
using StockManagementApplication.Models;
using System;
using System.Collections.Generic;

namespace StockManagementApplication.DAL
{
    public class StockOutRepository
    {
        private readonly string _connectionString = GenericRepository.ConnectionString();
        readonly GenericRepository _genericRepository = new GenericRepository();

        public bool Save(List<StockOut> stockOuts)
        {
            try
            {
                var rowAffected = 0;
                foreach (var stockOut in stockOuts)
                {
                    var query = "INSERT INTO Stocks(CategoryId, CompanyId, ItemId, OutType, OutQuantity, ReceiveDate, CreateBy, CreateDate) VALUES(" + stockOut.CategoryId + "," +
                                "" + stockOut.CompanyId + "," + stockOut.ItemId + ",'" + stockOut.StockOutType + "'," + stockOut.Quantity + ",'" + stockOut.OutDate + "','" + stockOut.CreateBy + "'" +
                                ",'" + stockOut.CreateDate + "')";

                    rowAffected = _genericRepository.ExecuteNonQuery(query, _connectionString);
                }

                return rowAffected > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
