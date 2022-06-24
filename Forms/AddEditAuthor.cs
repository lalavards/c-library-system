using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_System.Data_Model;

namespace Libray_System.Forms
{
    public partial class AddEditAuthor : Form,  IAddEdit
    {
        public AddEditAuthor(Author author = null)
        {
            InitializeComponent();
            this.author = author;
            if (author != null)
                DisplaySelectedObject();

        }

        public Author author;


        public void DisplaySelectedObject() // Kapag Mag EEDIT, tatawagin ito ---->
        {
            tbName.DataBindings.Add("Text", author, "Name");
            tbAbout.DataBindings.Add("Text", author, "About");


        }

        private void btnCancel_Click(object sender, EventArgs e) 
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void Clear() 
        {
            tbName.Clear();
            tbAbout.Clear();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (author == null)
            {
                Author a = new Author()
                {
             
                    Name = tbName.Text,
                    About = tbAbout.Text

                };
                if (Author.Add(a))// Add na sa list
                {
                    Clear(); //Para mawala yung laman sa loob ng form kapag nag add
                    DialogResult = DialogResult.OK;
                }
                   
            }
            else
            {
                if (Author.Update(author))
                {
                    Clear(); //Para mawala yung laman sa loob ng form kapag nag add
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }

}
