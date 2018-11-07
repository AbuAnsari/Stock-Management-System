using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using StockManagementApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class StockOutFormASD : Form
    {
        private readonly CategoryManager _categoryManager = new CategoryManager();
        private readonly ItemManager _itemManager = new ItemManager();
        private readonly StockInManager _stockInManager = new StockInManager();
        public StockOutFormASD()
        {
            InitializeComponent();
            ProductListDataGridView.AutoGenerateColumns = false;
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
                itemComboBox.DataSource = null;
                reorderLevelTextBox.Text = "";
                avialableQuantityTextBox.Text = "";
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
        private void companyComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                itemComboBox.DataSource = null;
                reorderLevelTextBox.Text = "";
                avialableQuantityTextBox.Text = "";
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
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        private void itemComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (itemComboBox.SelectedValue != null)
                {
                    var item = new Item();
                    item.Id = Convert.ToInt32(itemComboBox.SelectedValue);
                    var reader = _itemManager.GetReorderLevel(item);
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            reorderLevelTextBox.Text = reader["ReorderLevel"].ToString();
                        }

                    }
                    StockIn stock = new StockIn();
                    stock.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
                    var reader1 = _stockInManager.GetAvaialableQtyByItemId(stock);
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            var avialableQty = reader1["InQuantity"].ToString();
                            if (String.IsNullOrEmpty(avialableQty))
                            {
                                avialableQuantityTextBox.Text = 0.ToString();
                                return;
                            }

                            avialableQuantityTextBox.Text = avialableQty;
                        }
                    }
                    return;
                }
                reorderLevelTextBox.Text = 0.ToString();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private List<StockOut> stockOuts = new List<StockOut>();
        private List<StockOutViewModel> productVm = new List<StockOutViewModel>();
        private int serial = 0;
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryComboBox.SelectedValue == null || companyComboBox.SelectedValue == null || itemComboBox.SelectedValue == null || quantityTextBox.Text == "")
                {
                    string validationMessage = "Please Fillup Required Field";
                    MessageBox.Show(validationMessage);
                    return;
                }

                var stock = new StockOut
                {
                    CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue),
                    CompanyId = Convert.ToInt32(companyComboBox.SelectedValue),
                    ItemId = Convert.ToInt32(itemComboBox.SelectedValue),
                    Quantity = Convert.ToInt32(quantityTextBox.Text)
                };
                stockOuts.Add(stock);

                serial++;
                var product = new StockOutViewModel()
                {
                    Id = stock.Id,
                    Category = categoryComboBox.Text,
                    Company = companyComboBox.Text,
                    Name = itemComboBox.Text,
                    Quantity = stock.Quantity,
                    SerialNo = serial
                };
                productVm.Add(product);
                GetAllInList();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public void GetAllInList()
        {
            try
            {
                ProductListDataGridView.DataSource = null;
                ProductListDataGridView.DataSource = productVm;
                ProductListDataGridView.AutoGenerateColumns = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
