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
using Libray_System;

namespace Library_System.Forms
{
    public partial class AddEditUser : Form, IAddEdit
    {
        public AddEditUser(User user = null)
        {
         
            InitializeComponent();

            cbPosition.ValueMember = "Id"; //Yung value member ng Data Source manggagaling kay Id
            cbPosition.DisplayMember = "Name"; // Nandito yung name property ng list of position
            cbPosition.DataSource = Position.Lists;

            User = user;
            if (user != null)
                DisplaySelectedObject();
        }
        User User;
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (ComparePassword())
            {
               
                if (User == null)
                {

                    User user = new User()
                    {
                 
                        Name = tbName.Text,
                        Username = tbUsername.Text,
                        Password = tbPassword.Text,
                        PositionId = int.Parse(cbPosition.SelectedValue.ToString()),//Isasave na yung Value, hindi na yung Text property
                        Status = cbActive.Checked, //Boolean
                        Image = pictureBox1.Image
                    };

                    if (User.Add(user))
                        DialogResult = DialogResult.OK;
                }
                else
                {
                    User.Image = pictureBox1.Image; //Image Update
                    if (User.Update(User)) // Update data
                        DialogResult = DialogResult.OK; 
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; //Automatic close
        }

     

        public void DisplaySelectedObject() 
        {

            pictureBox1.Image = User.Image;
            tbName.DataBindings.Add("Text", User, "Name");
            tbUsername.DataBindings.Add("Text", User, "Username");
            tbPassword.DataBindings.Add("Text", User, "Password");
            cbPosition.DataBindings.Add("SelectedValue", User, "PositionId");
            cbPosition.SelectedIndex = User.PositionId;
            cbActive.DataBindings.Add("Checked", User, "Status");
        }

        bool ComparePassword() // For password
        {
            if (tbPassword.Text == tbRetypePassword.Text)
                return true;
            return false;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Utilities.BrowseImage(pictureBox1); //User to Open Dialog Box
        }

        public void Clear()
        {
            pictureBox1.Image = null;
            tbName.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            cbPosition.SelectedIndex = 0;
            tbPassword.Clear();
            tbRetypePassword.Clear();
            cbActive.Checked = true;
        }

        private void AddEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clear();
        }
    }
}
