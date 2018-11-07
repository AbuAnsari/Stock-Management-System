using StockManagementApplication.DAL;
using StockManagementApplication.Models;
using StockManagementApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;

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

        public List<SellItemViewModel> GetAllSellItem(DateTime fromDate, DateTime toDate)
        {
            try
            {
                var dataTable = _stockOutRepository.GetAllSellItem(fromDate, toDate);
                var viewModels = new List<SellItemViewModel>();
                int serial = 1;
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var viewModel = new SellItemViewModel();
                    viewModel.SerialNo = serial;
                    viewModel.Name = dataRow["Name"].ToString();
                    viewModel.Quantity = Convert.ToInt32(dataRow["OutQuantity"]);
                    viewModels.Add(viewModel);
                    serial++;
                }

                return viewModels;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
