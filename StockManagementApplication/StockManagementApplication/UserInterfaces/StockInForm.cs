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
        }

        private readonly CategoryManager _categoryManager = new CategoryManager();
        private readonly CompanyManager _companyManager = new CompanyManager();
        private readonly ItemManager _itemManager = new ItemManager();
        private readonly StockInManager _stockInManager = new StockInManager();
        private void StockInForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadCompany();

        }

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

        public void LoadCompany()
        {
            try
            {
                var companies = _companyManager.GetAll();
                companyComboBox.DataSource = companies;
                companyComboBox.DisplayMember = "Name";
                companyComboBox.ValueMember = "Id";
                companyComboBox.SelectedIndex = -1;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                var items = _itemManager.GetAllItemByCategoryId(item);
                itemComboBox.DataSource = items;
                itemComboBox.DisplayMember = "Name";
                itemComboBox.ValueMember = "Id";

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
