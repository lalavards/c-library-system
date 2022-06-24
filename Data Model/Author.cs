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
    public class Author:CRUD<Author>
    {
        public int Id { get; set; } = NewId();
        public string Name { get; set; }
        public string About { get; set; }

        
    }
}
