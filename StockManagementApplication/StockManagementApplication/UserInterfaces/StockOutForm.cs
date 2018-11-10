using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using StockManagementApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class StockOutForm : Form
    {
        private readonly CategoryManager _categoryManager = new CategoryManager();
        private readonly ItemManager _itemManager = new ItemManager();
        private readonly StockInManager _stockInManager = new StockInManager();
        private readonly StockOutManager _stockOutManager = new StockOutManager();
        public StockOutForm()
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
                    int avialableQty = 0;
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            avialableQty = Convert.ToInt32(reader1["AvialableQty"]);
                            if (avialableQty == 0)
                            {
                                avialableQuantityTextBox.Text = 0.ToString();
                                return;
                            }
                        }
                    }

                    foreach (var stockOut in _stockOuts)
                    {
                        if (stock.ItemId == stockOut.ItemId)
                        {
                            avialableQty -= stockOut.Quantity;
                        }

                    }
                    avialableQuantityTextBox.Text = avialableQty.ToString();
                    return;
                }
                reorderLevelTextBox.Text = 0.ToString();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private readonly List<StockOut> _stockOuts = new List<StockOut>();
        private readonly List<StockOutViewModel> _productViewModels = new List<StockOutViewModel>();
        private int _serial = 1;
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(quantityTextBox.Text);
                if (categoryComboBox.SelectedValue == null || companyComboBox.SelectedValue == null || itemComboBox.SelectedValue == null || qty == 0)
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

                var avialableQty = avialableQuantityTextBox.Text;
                if (stock.Quantity > Convert.ToInt32(avialableQty))
                {
                    string message = "Quantity is not Available";
                    MessageBox.Show(message);
                    return;
                }

                var isReorder = ReorderLevel(stock);
                if (isReorder)
                {
                    string message = "Please Reorder this Item";
                    MessageBox.Show(message);
                    return;
                }
                var isExist = IsExist(stock);
                if (!isExist)
                {
                    _stockOuts.Add(stock);
                }

                var product = new StockOutViewModel()
                {
                    Id = stock.Id,
                    Category = categoryComboBox.Text,
                    Company = companyComboBox.Text,
                    Name = itemComboBox.Text,
                    Quantity = stock.Quantity,
                    SerialNo = _serial,

                };
                _serial++;
                var isItemExist = IsItemExist(product);
                if (!isItemExist)
                {
                    _productViewModels.Add(product);
                }

                RefreshField();
                GetAllInList();

            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        public bool IsExist(StockOut stockOut)
        {
            try
            {
                foreach (var stock in _stockOuts)
                {
                    if (stockOut.ItemId == stock.ItemId)
                    {
                        stock.Quantity += stockOut.Quantity;
                        return true;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool IsItemExist(StockOutViewModel viewModel)
        {
            try
            {
                foreach (var model in _productViewModels)
                {
                    if (viewModel.Name == model.Name)
                    {
                        model.Quantity += viewModel.Quantity;
                        return true;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void GetAllInList()
        {
            try
            {
                ProductListDataGridView.DataSource = null;
                ProductListDataGridView.DataSource = _productViewModels;
                ProductListDataGridView.AutoGenerateColumns = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void RefreshField()
        {
            itemComboBox.Text = reorderLevelTextBox.Text = avialableQuantityTextBox.Text = quantityTextBox.Text = "";
        }
        public bool ReorderLevel(StockOut stockOut)
        {
            try
            {
                var reorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                int quantityInDb = Convert.ToInt32(avialableQuantityTextBox.Text);
                int quantity = stockOut.Quantity;
                int orderQty = quantity + reorderLevel;

                if (quantityInDb < orderQty)
                {
                    return true;
                }

                return false;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_stockOuts != null)
                {
                    foreach (var stockOut in _stockOuts)
                    {
                        stockOut.StockOutType = StockOutType.Sell;
                        stockOut.OutDate = DateTime.Now;
                        stockOut.CreateBy = LoggerInfo.UserName;
                        stockOut.CreateDate = DateTime.Now;
                    }

                    var isSave = _stockOutManager.Save(_stockOuts);
                    if (isSave)
                    {
                        string successMessage = "Info Save Successfully";
                        MessageBox.Show(successMessage);
                        return;
                    }
                    string failMessage = "Info Save Fail";
                    MessageBox.Show(failMessage);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_stockOuts != null)
                {
                    foreach (var stockOut in _stockOuts)
                    {
                        stockOut.StockOutType = StockOutType.Damage;
                        stockOut.OutDate = DateTime.Now;
                        stockOut.CreateBy = LoggerInfo.UserName;
                        stockOut.CreateDate = DateTime.Now;
                    }

                    var isSave = _stockOutManager.Save(_stockOuts);
                    if (isSave)
                    {
                        string successMessage = "Info Save Successfully";
                        MessageBox.Show(successMessage);
                        return;
                    }
                    string failMessage = "Info Save Fail";
                    MessageBox.Show(failMessage);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void LostButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_stockOuts != null)
                {
                    foreach (var stockOut in _stockOuts)
                    {
                        stockOut.StockOutType = StockOutType.Lost;
                        stockOut.OutDate = DateTime.Now;
                        stockOut.CreateBy = LoggerInfo.UserName;
                        stockOut.CreateDate = DateTime.Now;
                    }

                    var isSave = _stockOutManager.Save(_stockOuts);
                    if (isSave)
                    {
                        string successMessage = "Info Save Successfully";
                        MessageBox.Show(successMessage);
                        return;
                    }
                    string failMessage = "Info Save Fail";
                    MessageBox.Show(failMessage);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}
