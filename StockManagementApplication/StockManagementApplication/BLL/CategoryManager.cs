using StockManagementApplication.DAL;
using StockManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace StockManagementApplication.BLL
{
    public class CategoryManager
    {
        readonly CategoryRepository _categoryRepository = new CategoryRepository();

        public bool Save(Category category)
        {
            var save = _categoryRepository.Save(category);
            return save;
        }

        public bool IsNameExist(Category category)
        {
            var isExist = _categoryRepository.IsNameExist(category);
            return isExist;
        }

        public List<Category> GetAll()
        {
            try
            {
                var dataTable = _categoryRepository.GetAll();
                List<Category> categoryList = new List<Category>();
                int serialNo = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    Category category = new Category();
                    category.Serial = serialNo;
                    category.Id = Convert.ToInt32(row["Id"]);
                    category.Name = row["Name"].ToString();
                    categoryList.Add(category);
                    serialNo++;
                }

                return categoryList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Update(Category category)
        {
            var update = _categoryRepository.Update(category);
            return update;
        }
    }
}
