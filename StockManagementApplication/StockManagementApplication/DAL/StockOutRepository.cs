
using StockManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;

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

        public DataTable GetAllSellItem(DateTime fromDate, DateTime toDate)
        {
            try
            {
                var query = "SELECT i.Name, s.OutQuantity FROM Stocks s LEFT JOIN Items i ON i.Id= s.ItemId WHERE s.OutType= 1 " +
                            "AND s.ReceiveDate BETWEEN '" + fromDate + "' AND '" + toDate.AddDays(1) + "'";
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
