using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class StockInForm : Form
    {
        public StockInForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        private readonly CategoryManager _categoryManager = new CategoryManager();
        private readonly CompanyManager _companyManager = new CompanyManager();
        private readonly ItemManager _itemManager = new ItemManager();
        private readonly StockInManager _stockInManager = new StockInManager();
        public void LoadCategory()
        {
            try
            {
                var categories = _categoryManager.GetAll();
                categoryComboBox.DataSource = categories;
                categoryComboBox.DisplayMember = "Name";
                categoryComboBox.ValueMember = "Id";
                categoryComboBox.SelectedIndex = -1;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            companyComboBox.DataSource = null;
            itemComboBox.DataSource = null;
            if (categoryComboBox.SelectedValue != null)
            {
                var item = new Item();
                item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                var items = _itemManager.GetAllCompanyByCategoryId(item);
                companyComboBox.DataSource = items;
                companyComboBox.DisplayMember = "Name";
                companyComboBox.ValueMember = "Id";
                companyComboBox.SelectedIndex = -1;
            }
        }
        private void companyComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            itemComboBox.DataSource = null;
            if (companyComboBox.SelectedValue != null)
            {
                Item item = new Item();
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                var items = _itemManager.GetAllItemByCompanyId(item);
                itemComboBox.DataSource = items;
                itemComboBox.DisplayMember = "Name";
                itemComboBox.ValueMember = "Id";
                itemComboBox.SelectedIndex = -1;
            }
        }
    }
}
