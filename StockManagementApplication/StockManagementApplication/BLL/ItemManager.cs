using StockManagementApplication.DAL;
using StockManagementApplication.Models;
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
    }
}
