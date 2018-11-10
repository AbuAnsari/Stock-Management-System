using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class CategoryForm : Form
    {
        readonly CategoryManager _categoryManager = new CategoryManager();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            SaveButton.Visible = true;
            UpdateButton.Visible = false;
            GetAllCategory();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "")
                {
                    var validationMessage = "Please give category name";
                    messageLabel.Text = validationMessage;
                    return;
                }
                var category = new Category();
                category.Name = nameTextBox.Text;
                category.CreateBy = LoggerInfo.UserName;
                category.CreateDate = DateTime.Now;
                var isExist = _categoryManager.IsNameExist(category);
                if (isExist)
                {
                    var validationMessage = "Name already exist. Please give another name";
                    messageLabel.Text = validationMessage;
                    return;
                }
                var isSave = _categoryManager.Save(category);
                if (isSave)
                {
                    RefreshFiled();
                    GetAllCategory();
                    return;
                }
                var failMessage = "Category info Save Fail";
                messageLabel.Text = failMessage;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public void GetAllCategory()
        {
            var categoryList = _categoryManager.GetAll();
            CategoryDataGridView.DataSource = categoryList;
        }

        public void RefreshFiled()
        {
            nameTextBox.Text = hiddenLabel.Text = "";
            SaveButton.Visible = true;
            UpdateButton.Visible = false;
        }

        private void CategoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hiddenLabel.Text = CategoryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameTextBox.Text = CategoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            SaveButton.Visible = false;
            UpdateButton.Visible = true;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "")
                {
                    var validationMessage = "Please give category name";
                    messageLabel.Text = validationMessage;
                    return;
                }
                var category = new Category();
                category.Id = Convert.ToInt32(hiddenLabel.Text);
                category.Name = nameTextBox.Text;
                category.UpdateBy = LoggerInfo.UserName;
                category.UpdateDate = DateTime.Now;
                var isExist = _categoryManager.IsNameExist(category);
                if (isExist)
                {
                    var validationMessage = "Name already exist. Please give another name";
                    messageLabel.Text = validationMessage;
                    return;
                }

                var isUpdate = _categoryManager.Update(category);
                if (isUpdate)
                {
                    RefreshFiled();
                    GetAllCategory();
                    return;
                }
                var failMessage = "Category info Update Fail";
                messageLabel.Text = failMessage;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RefreshFiled();
        }
    }
}
