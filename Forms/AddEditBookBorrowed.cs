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
    public partial class AddEditBookBorrowed : Form, IAddEdit
    {
        Book_Borrowed BookBorrowed;
        bool isNew = true;
        public AddEditBookBorrowed(Book_Borrowed bookBorrowed = null)
        {
            InitializeComponent();

            cbStudent.ValueMember = "Id";
            cbStudent.DisplayMember = "Name";
            cbStudent.DataSource = Student.Lists;
            cbStudent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbStudent.AutoCompleteSource = AutoCompleteSource.ListItems;


            cbUser.ValueMember = "Id";
            cbUser.DisplayMember = "Name";
            cbUser.DataSource = User.Lists;
            cbUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUser.AutoCompleteSource = AutoCompleteSource.ListItems;


            cbBook.ValueMember = "Id";
            cbBook.DisplayMember = "Name";
            cbBook.DataSource = Book.Lists;
            cbBook.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbBook.AutoCompleteSource = AutoCompleteSource.ListItems;

            this.BookBorrowed = bookBorrowed;
            if (BookBorrowed != null)
            {
                isNew = false;
                DisplaySelectedObject();
            }
        }

        


        public void DisplaySelectedObject() 
        {
     
            cbStudent.SelectedValue = BookBorrowed.StudentId;
            cbUser.SelectedValue = BookBorrowed.UserId;
            cbBook.SelectedValue = BookBorrowed.BookId;
            dtDate.Value = DateTime.Now;
            dtDateReturn.Value = DateTime.Now;
            tbRemarks.Text = BookBorrowed.Remarks;


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isNew)
                BookBorrowed = new Book_Borrowed();

            BookBorrowed.StudentId = int.Parse(cbStudent.SelectedValue.ToString());
            BookBorrowed.UserId = int.Parse(cbUser.SelectedValue.ToString());
            BookBorrowed.BookId = int.Parse(cbBook.SelectedValue.ToString());

            BookBorrowed.Date = dtDate.Value;
            BookBorrowed.DateReturn = dtDateReturn.Value;
            BookBorrowed.Remarks = tbRemarks.Text;
          

            if (isNew)
            {
                if (Book_Borrowed.Add(BookBorrowed))
                    DialogResult = DialogResult.OK;
            }
            else
               if (Book_Borrowed.Update(BookBorrowed))
                DialogResult = DialogResult.OK;
        }

        public void Clear()
        {
            cbStudent.Text = string.Empty;
            cbUser.Text = string.Empty;
            cbBook.Text = string.Empty;
            dtDate.Value = DateTime.Now;
            dtDateReturn.Value = DateTime.Now;
            tbRemarks.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; //Automatic close
        }

        private void AddEditBookBorrowed_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clear();
        }
    }
}
