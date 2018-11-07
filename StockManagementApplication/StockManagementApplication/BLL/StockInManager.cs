using StockManagementApplication.DAL;
using StockManagementApplication.Models;
using System.Data.SqlClient;

namespace StockManagementApplication.BLL
{
    public class StockInManager
    {
        readonly StockInRepository _stockInRepository = new StockInRepository();

        public bool Save(StockIn stock)
        {
            var save = _stockInRepository.Save(stock);
            return save;
        }

        public SqlDataReader GetAvaialableQtyByItemId(StockIn stock)
        {
            var reader = _stockInRepository.GetAvaialableQtyByItemId(stock);
            return reader;
        }
    }
}
