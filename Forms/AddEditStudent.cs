using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_System;
using Library_System.Data_Model;

namespace Libray_System.Forms
{
    public partial class AddEditStudent : Form, IAddEdit
    {
        public AddEditStudent(Student student = null)
        {
            InitializeComponent();
            this.student = student;
            if (student != null)
                DisplaySelectedObject();
        }

        public Student student;

        int NewId()
        {

            try
            {
                                                        //x => ___ (Anong property ang gusto kunin - edi yung Id sa User)
                return Student.Lists.Max(x => x.Id) + 1; // +1 means everytime na magkecreate ng bago
            }
            catch { return 0; }
        }

        public void DisplaySelectedObject() // Kapag Mag EEDIT, tatawagin ito ---->
        {
            pictureBox1.Image = student.Image;
            tbName.DataBindings.Add("Text", student, "Name");
            cbActive.DataBindings.Add("Checked", student, "Status");

        }

        public void Clear()
        {
            tbName.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                Student a = new Student()
                {
                    Id = NewId(),
                    Name = tbName.Text,
                    Status = cbActive.Checked,
                    Image = pictureBox1.Image

                };
                if (Student.Add(a))// Add na sa list
                {
                    Clear(); //Para mawala yung laman sa loob ng form kapag nag add
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
               student.Image = pictureBox1.Image;

                if (Student.Update(student))
                {
                    Clear(); //Para mawala yung laman sa loob ng form kapag nag add
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Utilities.BrowseImage(pictureBox1); //User to Open Dialog Box
        }
    }
}
