using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_System.Data_Model;
namespace Libray_System.Views
{
    internal class BookBorrowed
    {
        public int Id { get; set; } 
        public string Student_ { get; set; }
        public string Username { get; set; } 
        public string BookTitle { get; set; }
        public DateTime Date { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Remarks { get; set; }

        public static List<BookBorrowed> View = new List<BookBorrowed>(); // Actual Viewing of data

        public static List<BookBorrowed> RefreshMethod()
        {
            var bookborrowed = Book_Borrowed.Lists;
            var stud = Student.Lists;
            var user = User.Lists;
            var book_ = Book.Lists;

            //Language Integrated Query
            var newEntity = from bb in bookborrowed
                            join s in stud on bb.StudentId equals s.Id
                            join u in user on bb.UserId equals u.Id
                            join bk in book_ on bb.BookId equals bk.Id



                            select new BookBorrowed
                            {
                                Id = bb.Id,
                                //Names based in Id
                                Student_ = s.Name,
                                Username = u.Name,
                                BookTitle = bk.Name,
                                Date = bb.Date,
                                ReturnDate = bb.DateReturn,
                                Remarks = bb.Remarks

                            };

            View = newEntity.ToList();
            return View;

        }

        public static List<BookBorrowed> SearchView(string value)
        {
            try
            {
                return View.Where(d => d.Student_.Contains(value)).ToList();
            }
            catch { return null; }

        }
    }
}
