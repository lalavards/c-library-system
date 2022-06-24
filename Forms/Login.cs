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

namespace Library_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckUser()) // Ichecheck kung nag eexist si User, if nag eexist at tama password, mag O-OK
                DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        bool CheckUser() // Para malaman kung yung username ay nag eexist na sa database
        {
            try
            {
                if (User.Lists.Count > 0) //Para malaman kung nag eexist na yung Name sa ating DATA, AND ANG DATA natin ay yung ListofUser
                {
                    User u = User.Lists.First(t => t.Username == tbUsername.Text); 
                    //Hahanapin yung first element na kung saan ang Username ay equal sa linagay na Username sa TEXTBOX
                    


                    if (u.Password == tbPassword.Text) //Para malaman kung same yung password
                        return true; // if same ang password

                    MessageBox.Show("Incorrect Password"); // Kapag hindi same
                }
                return false; // kapag wala pang laman yung User mag fafalse siya
            }
            catch 
            {
                MessageBox.Show("Wala Naman"); //Kapag hindi mahanap or nag eexist, ito lalabas
                return false;

            }
        }
    }
}
