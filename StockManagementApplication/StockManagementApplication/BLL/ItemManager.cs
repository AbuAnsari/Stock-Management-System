using StockManagementApplication.DAL;
using StockManagementApplication.Models;
using StockManagementApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StockManagementApplication.BLL
{
    public class ItemManager
    {
        readonly ItemRepository _itemRepository = new ItemRepository();

        public bool Save(Item item)
        {
            var save = _itemRepository.Save(item);
            return save;
        }

        public bool IsNameExist(Item item)
        {
            var reader = _itemRepository.IsNameExist(item);
            return reader;
        }

        public DataTable GetAllCompanyByCategoryId(Item item)
        {
            var dataTable = _itemRepository.GetAllCompanyByCategoryId(item);
            return dataTable;
        }

        public DataTable GetAllItemByCompanyId(Item item)
        {
            var dataTable = _itemRepository.GetAllItemByCompanyId(item);
            return dataTable;
        }

        public SqlDataReader GetReorderLevel(Item item)
        {
            var reorderLevel = _itemRepository.GetReorderLevel(item);
            return reorderLevel;
        }

        public List<ItemReportViewModel> GetItemReport(Item item)
        {
            var dataTable = _itemRepository.GetItemReport(item);
            List<ItemReportViewModel> viewModels = new List<ItemReportViewModel>();
            int serial = 1;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ItemReportViewModel viewModel = new ItemReportViewModel();
                viewModel.Serial = serial;
                viewModel.Item = dataRow["ItemName"].ToString();
                viewModel.Company = dataRow["CompanyName"].ToString();
                viewModel.Category = dataRow["CategoryName"].ToString();
                viewModel.AvailableQuantity = Convert.ToInt32(dataRow["AvailableQty"]);
                viewModel.ReorderLevel = Convert.ToInt32(dataRow["ReorderLevel"]);
                viewModels.Add(viewModel);
                serial++;
            }

            return viewModels;
        }
    }
}
