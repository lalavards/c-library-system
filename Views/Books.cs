using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_System.Data_Model;

namespace Libray_System.Views
{
    class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Category { get; set; }
        public DateTime DatePublished { get; set; }
        public bool Status { get; set; }

        public static List<Books> View = new List<Books>(); // Actual Viewing of data

        public static List<Books> RefreshMethod()
        {
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

            View = newEntity.ToList();
            return View; 

        }

        public static List<Books> SearchView (string value)
        {
            try
            {
                return View.Where(d => d.Title.Contains(value)).ToList();
            }
            catch { return null; }
            
        }





    }
}
