using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Libray_System.Data_Model;

namespace Library_System.Data_Model
{
    [Serializable]
    public class Book_Borrowed:CRUD<Book_Borrowed>
    {
        public int Id { get; set; } = NewId();
        public int StudentId { get; set; }
        public int UserId { get; set; } 
        public int BookId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateReturn { get; set; }
        public string Remarks { get; set; } //To know if there is a damage in the book
    }
}
