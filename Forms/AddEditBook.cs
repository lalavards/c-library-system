using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_System;
using Library_System.Data_Model;

namespace Libray_System.Forms
{
    public partial class AddEditBook : Form, IAddEdit
    {
        Book book;
        bool isNew = true;

        public AddEditBook(Book book = null)
        {
            InitializeComponent();

            cbAuthor.ValueMember = "Id"; //Yung value member ng Data Source manggagaling kay Id
            cbAuthor.DisplayMember = "Name"; // Nandito yung name property ng list of position
            cbAuthor.DataSource = Author.Lists;
            cbAuthor.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //Para macomplete yung laman ng Authors comboBox
            cbAuthor.AutoCompleteSource = AutoCompleteSource.ListItems;


            cbCategory.ValueMember = "Id"; //Yung value member ng Data Source manggagaling kay Id
            cbCategory.DisplayMember = "Name"; // Nandito yung name property ng list of position
            cbCategory.DataSource = Book_Category.Lists;
            cbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //Para macomplete yung laman ng Authors comboBox
            cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;



            this.book = book;
            if (book != null)
            {
                isNew = false;
                DisplaySelectedObject();
            }
        }

        public void Clear()
        {
            tbTitle.Clear();
            cbAuthor.Text = string.Empty;
            cbCategory.Text = string.Empty;
            tbDescription.Clear();
            tbDate.Value = DateTime.Now;
            tbDescription.Clear();
            cbActive.Checked = true;

        }


        public void DisplaySelectedObject() // Kapag Mag EEDIT, tatawagin ito ---->
        {


            tbTitle.Text = book.Name;
            cbAuthor.SelectedValue = book.AuthorId;
            tbDate.Value = DateTime.Now;
            tbDescription.Text = book.Description;
            cbCategory.SelectedValue = book.CategoryId;
            cbActive.Checked = book.Status;

           

        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isNew)
                book = new Book();
            book.Name = tbTitle.Text;
            book.AuthorId = int.Parse(cbAuthor.SelectedValue.ToString());
            book.DatePublished = tbDate.Value;
            book.Description = tbDescription.Text;
            book.CategoryId = int.Parse(cbCategory.SelectedValue.ToString());
            book.Status = cbActive.Checked;

            if (isNew)
            {
                if (Book.Add(book))
                    DialogResult = DialogResult.OK;
            }
            else
               if (Book.Update(book))
                DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; //Automatic close
        }
    }
}
