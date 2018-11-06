﻿using StockManagementApplication.DAL;
using StockManagementApplication.Models;
using System.Data;

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

        public DataTable GetAllItemByCategoryId(Item item)
        {
            var dataTable = _itemRepository.GetAllItemByCategoryId(item);
            return dataTable;
        }
    }
}
