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
    public class Book:CRUD<Book>
    {
        public int Id { get; set; } = NewId();
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public DateTime DatePublished { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public bool Status { get; set; }
    }
}
