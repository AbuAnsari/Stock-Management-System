using StockManagementApplication.DAL;
using StockManagementApplication.Models;

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
    }
}
