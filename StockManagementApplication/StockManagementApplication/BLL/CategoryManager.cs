using StockManagementApplication.DAL;
using StockManagementApplication.Models;

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
    }
}
