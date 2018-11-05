using StockManagementApplication.BLL;
using StockManagementApplication.Models;
using System;
using System.Windows.Forms;

namespace StockManagementApplication.UserInterfaces
{
    public partial class CategoryForm : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
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
                    MessageBox.Show(validationMessage);
                    return;
                }
                var category = new Category();
                category.Name = nameTextBox.Text;
                category.CreateBy = "Admin";
                category.CreateDate = DateTime.Now;
                var isExist = _categoryManager.IsNameExist(category);
                if (isExist)
                {
                    var validationMessage = "Name already exist. Please give another name";
                    MessageBox.Show(validationMessage);
                    return;
                }
                var isSave = _categoryManager.Save(category);
                if (isSave)
                {
                    var successMessage = "Category info Save Successfully";
                    RefreshFiled();
                    MessageBox.Show(successMessage);
                    return;
                }
                var failMessage = "Category info Save Successfully";
                MessageBox.Show(failMessage);
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
            nameTextBox.Text = "";
        }

        private void CategoryDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hiddenLabel.Text = CategoryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameTextBox.Text = CategoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            SaveButton.Visible = false;
            UpdateButton.Visible = true;
        }
    }
}
