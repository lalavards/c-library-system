using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_System.Forms;
using Library_System.Data_Model;
using Libray_System.Forms;

namespace Libray_System
{
     public enum Type { User, Author, Student, Book, Book_Borrowed, Book_Category, Position } //List of Data, with no particular data type
    internal class ShowList<c> where c : class
    {

        public delegate bool delDelete(int id);//Kpag tinatawag ito ay parang tinatawag na rin yung method ng ibang class
        public delegate List<c> delSearch(string name);

        public delegate List<c> delRefreshView();

        ListForm lf = new ListForm();

        public List<c> Lists { get; set; }

        public Form AddEditForm { get; set; } // Used to call all add edit forms such as author and student
        public delSearch SearchMethod { get; set; }
        public delDelete DeleteMethod { get; set; }

        public delRefreshView RefreshView { get; set; }

        public bool isView { get; set; } = false;
        public Type ObjectType { get; set; }


        public void Show()
        {
            lf.btnNew.Click += BtnNew_Click;
            lf.btnDelete.Click += BtnDelete_Click;
            lf.btnEdit.Click += BtnEdit_Click;
            lf.tbSearch.KeyDown += TbSearch_KeyDown;
            Reload();
            lf.ShowDialog();
        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lf.dg.DataSource = SearchMethod(lf.tbSearch.Text);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ObjectType == Type.Author)
                EditAuthor();
            else if (ObjectType == Type.User)
                EditUser();
            else if (ObjectType == Type.Student)
                EditStudent();
            else if (ObjectType == Type.Book)
                EditBook();
            else if (ObjectType == Type.Book_Category)
                EditBook_Category();
            else if (ObjectType == Type.Book_Borrowed)
                EditBook_Borrowed();
            else if (ObjectType == Type.Position)
                EditPosition();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigurado ka ba?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(lf.dg.SelectedCells[0].Value.ToString());
                // Yung [0] ito ay tinatawag na index which means ito yung ID , so start siya lagi sa UNANG DATA
                if (DeleteMethod(id))
                    Reload();

            }

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (AddEditForm.ShowDialog() == DialogResult.OK)
                Reload();
        }

        void Reload()
        {
            lf.dg.DataSource = null;
            if (isView)
                lf.dg.DataSource = RefreshView(); //Used to refresh data
            else
                lf.dg.DataSource = Lists;
        }

        void EditUser()
        {
            User selectedUser = User.Lists.First(x => x.Id == int.Parse(lf.dg.SelectedCells[0].Value.ToString()));
            //kung ano yung number ang pinili ayun ang ma eedit
            //Ang kinukuha dito ay yung Selected Cells, whichi means yung Isang ROW

            AddEditUser ad = new AddEditUser(selectedUser); //For edit
            if (ad.ShowDialog() == DialogResult.OK)
                Reload();

        }

        void EditAuthor()
        {
            Author selectedUser = Author.Lists.First(x => x.Id == int.Parse(lf.dg.SelectedCells[0].Value.ToString()));

            AddEditAuthor ad = new AddEditAuthor(selectedUser); //For edit
            if (ad.ShowDialog() == DialogResult.OK)
                Reload();
        }

        void EditStudent()
        {
            Student selectedUser = Student.Lists.First(x => x.Id == int.Parse(lf.dg.SelectedCells[0].Value.ToString()));

            AddEditStudent ad = new AddEditStudent(selectedUser); //For edit
            if (ad.ShowDialog() == DialogResult.OK)
                Reload();
        }

        void EditBook()
        {
            Book selectedUser = Book.Lists.First(x => x.Id == int.Parse(lf.dg.SelectedCells[0].Value.ToString()));

            AddEditBook ad = new AddEditBook(selectedUser); //For edit
            if (ad.ShowDialog() == DialogResult.OK)
                Reload();
        }

        void EditBook_Category()
        {
            Book_Category selectedUser = Book_Category.Lists.First(x => x.Id == int.Parse(lf.dg.SelectedCells[0].Value.ToString()));

            AddEditBookCategory ad = new AddEditBookCategory(selectedUser); //For edit
            if (ad.ShowDialog() == DialogResult.OK)
                Reload();
        }

        void EditBook_Borrowed()
        {
            Book_Borrowed selectedUser = Book_Borrowed.Lists.First(x => x.Id == int.Parse(lf.dg.SelectedCells[0].Value.ToString()));

            AddEditBookBorrowed ad = new AddEditBookBorrowed(selectedUser); //For edit
            if (ad.ShowDialog() == DialogResult.OK)
                Reload();
        }

        void EditPosition()
        {
           Position selectedUser = Position.Lists.First(x => x.Id == int.Parse(lf.dg.SelectedCells[0].Value.ToString()));

           AddEditPosition ad = new AddEditPosition(selectedUser); //For edit
           if (ad.ShowDialog() == DialogResult.OK)
           Reload();
        }
    }
}
