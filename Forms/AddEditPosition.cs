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
    public partial class AddEditPosition : Form, IAddEdit
    {
        Position position;
        bool isNew = true;

        public AddEditPosition(Position position = null)
        {
            InitializeComponent();
            this.position = position;
            if(position != null)
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


        public void DisplaySelectedObject()
        {
            tbName.Text = position.Name;
            tbDescription.Text = position.Description;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (isNew)
                position = new Position();
            position.Name = tbName.Text;
            position.Description = tbDescription.Text;

            if (isNew)
            {
                if (Position.Add(position))
                    DialogResult = DialogResult.OK;
            }
            else 
               if (Position.Update(position))
                DialogResult = DialogResult.OK;
        }

        private void AddEditPosition_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clear();
        }
    }
}
