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
using Library_System.Forms;
using Library_System.Data_Model;
using Libray_System;
using Libray_System.Forms;
using Libray_System.Data_Model;
using Libray_System.Views;


namespace Library_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            User.Deserialize();
            Author.Deserialize();
            Student.Deserialize();
            Book.Deserialize();
            Book_Borrowed.Deserialize();
            Book_Category.Deserialize();
            Position.Deserialize();

            var book = Book.Lists;
            var aut = Author.Lists;
            var cat = Book_Category.Lists;

            //Language Integrated Query
            var newEntity = from b in book
                            join a in aut on b.AuthorId equals a.Id
                            join c in cat on b.CategoryId equals c.Id

                            select new Books
                            {
                                Id = b.Id,
                                //Names based in Id
                                Title = b.Name,   
                                AuthorName = a.Name,
                                Category = c.Name,
                                DatePublished = b.DatePublished, 
                                Status = b.Status
                                 
                            };

            dataGridView1.DataSource = newEntity.ToList();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowList<Users> s = new ShowList<Users>()
            {
                Lists = Users.View,
                AddEditForm = new AddEditUser(),
                DeleteMethod = User.Delete,
                SearchMethod = Users.SearchView,
                ObjectType = Libray_System.Type.User,
                RefreshView = Users.RefreshMethod,
                isView = true

            };

            s.Show();  
        }

        private void Form1_Load(object sender, EventArgs e)// LOGIN form
        {
            Login login = new Login();
            if (login.ShowDialog() != DialogResult.OK) 
            Application.Exit();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowList<Author> s = new ShowList<Author>()
            {
                Lists = Author.Lists,
                AddEditForm = new AddEditAuthor(),
                DeleteMethod = Author.Delete,
                SearchMethod = Author.Search,
                ObjectType = Libray_System.Type.Author
            };

            s.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowList<Student> s = new ShowList<Student>()
            {
                Lists = Student.Lists,
                AddEditForm = new AddEditStudent(),
                DeleteMethod = Student.Delete,
                SearchMethod = Student.Search,
                ObjectType = Libray_System.Type.Student
                
            };

            s.Show();
        }

        private void bOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowList<Books> s = new ShowList<Books>()
            {
                Lists = Books.View,
                AddEditForm = new AddEditBook(),
                DeleteMethod = Book.Delete,
                SearchMethod = Books.SearchView,
                ObjectType = Libray_System.Type.Book,
                RefreshView = Books.RefreshMethod,
                isView = true
            };

            s.Show();
        }

        private void bookBorrowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowList<BookBorrowed> s = new ShowList<BookBorrowed>()
            {
                Lists = BookBorrowed.View,
                AddEditForm = new AddEditBookBorrowed(),
                DeleteMethod = Book_Borrowed.Delete,
                SearchMethod = BookBorrowed.SearchView,
                ObjectType = Libray_System.Type.Book_Borrowed,
                RefreshView = BookBorrowed.RefreshMethod,
                isView = true
            };

            s.Show();
        }

        private void bookCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowList<Book_Category> s = new ShowList<Book_Category>()
            {
                Lists = Book_Category.Lists,
                AddEditForm = new AddEditBookCategory(),
                DeleteMethod = Book_Category.Delete,
                SearchMethod = Book_Category.Search,
                ObjectType = Libray_System.Type.Book_Category
            };

            s.Show();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowList<Position> s = new ShowList<Position>()
            {
                Lists = Position.Lists,
                AddEditForm = new AddEditPosition(),
                DeleteMethod = Position.Delete,
                SearchMethod = Position.Search,
                ObjectType = Libray_System.Type.Position
            };

            s.Show();
        }
    }
}
