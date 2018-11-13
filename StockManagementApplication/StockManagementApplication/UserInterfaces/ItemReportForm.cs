using StockManagementApplication.BLL;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class ItemReportForm : Form
    {
        readonly ItemManager _itemManager = new ItemManager();
        readonly CategoryManager _categoryManager = new CategoryManager();
        readonly CompanyManager _companyManager = new CompanyManager();
        public ItemReportForm()
        {
            InitializeComponent();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryComboBox.SelectedValue == null && companyComboBox.SelectedValue == null)
                {
                    string validationMessage = "Please Selcet atleast one ComboBox";
                    messageLabel.Text = validationMessage;
                    return;
                }

                var categoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                var companyId = Convert.ToInt32(companyComboBox.SelectedValue);
                var itemList = _itemManager.GetItemReport(categoryId, companyId);
                ItemReportDataGridView.DataSource = itemList;


            }
            catch (Exception exception)
            {
                messageLabel.Text = exception.Message;
            }
        }


    }
}
