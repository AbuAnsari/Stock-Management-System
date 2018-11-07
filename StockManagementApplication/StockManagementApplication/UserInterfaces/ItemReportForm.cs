using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class ItemReportForm : Form
    {
        readonly ItemManager _itemManager = new ItemManager();
        readonly CategoryManager _categoryManager = new CategoryManager();
        public ItemReportForm()
        {
            InitializeComponent();
            LoadCategory();
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
        private void categoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                companyComboBox.DataSource = null;
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
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryComboBox.SelectedValue == null && companyComboBox.SelectedValue == null)
                {
                    string validationMessage = "Please Selcet atleast one ComboBox";
                    MessageBox.Show(validationMessage);
                    return;
                }
                Item item = new Item();
                item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                var itemList = _itemManager.GetItemReport(item);
                ItemReportDataGridView.DataSource = itemList;


            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


    }
}
