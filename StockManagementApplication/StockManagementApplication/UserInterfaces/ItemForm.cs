using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private readonly CategoryManager _categoryManager = new CategoryManager();
        private readonly CompanyManager _companyManager = new CompanyManager();
        private readonly ItemManager _itemManager = new ItemManager();
        private void ItemForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadCompany();
            reorderLevelTextBox.Text = 0.ToString();
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryComboBox.SelectedItem == null || companyComboBox.SelectedItem == null || itemNameTextBox.Text == "")
                {
                    var validationMessage = "Please fillup the required field";
                    MessageBox.Show(validationMessage);
                    return;
                }

                Item item = new Item();
                item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                item.Name = itemNameTextBox.Text;
                item.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                item.CreateBy = LoggerInfo.UserName;
                item.CreateDate = DateTime.Now;
                var isNameExist = _itemManager.IsNameExist(item);
                if (isNameExist)
                {
                    var validationMessage = "Item Name already exist";
                    MessageBox.Show(validationMessage);
                    return;
                }

                var isSave = _itemManager.Save(item);
                if (isSave)
                {
                    RefreshField();
                    var successMessage = "Item Info Save Successfully";
                    MessageBox.Show(successMessage);
                    return;
                }
                var failMessage = "Item Info Save Successfully";
                MessageBox.Show(failMessage);

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public void RefreshField()
        {
            itemNameTextBox.Text = "";
        }
    }
}
