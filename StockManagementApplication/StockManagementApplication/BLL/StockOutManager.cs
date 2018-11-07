using StockManagementApplication.DAL;
using StockManagementApplication.Models;
using System.Collections.Generic;

namespace StockManagementApplication.BLL
{
    public class StockOutManager
    {
        readonly StockOutRepository _stockOutRepository = new StockOutRepository();

        public bool Save(List<StockOut> stockOuts)
        {
            var save = _stockOutRepository.Save(stockOuts);
            return save;
        }
    }
}
