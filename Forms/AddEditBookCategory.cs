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
using Libray_System;

namespace Libray_System.Forms
{
    public partial class AddEditBookCategory : Form, IAddEdit
    {

        public Book_Category category;
        bool isNew = true;

        public AddEditBookCategory(Book_Category category = null)
        {
            InitializeComponent();

            this.category = category;
            if (category != null)
            {
                isNew = false;
                DisplaySelectedObject();
            }
                
       }

        public void Clear()
        {
            tbName.Clear();
            tbDescription.Clear();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isNew)
                category = new Book_Category();
            category.Name = tbName.Text;
            category.Description = tbDescription.Text;

            if(isNew)
            {
                if(Book_Category.Add(category))
                    DialogResult = DialogResult.OK;
            }
            else 
               if(Book_Category.Update(category))
                DialogResult = DialogResult.OK;
        }



        public void DisplaySelectedObject() // Kapag Mag EEDIT, tatawagin ito ---->
        {
            tbName.Text = category.Name;
            tbDescription.Text = category.Description;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddEditBookCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clear();
        }
    }
}
