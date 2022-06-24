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

    public class User:CRUD<User> // User is an object
    {
        //PROPERTIES
        public int Id { get; set; } = NewId();
        public string Name { get; set; }
        public System.Drawing.Image Image { get; set; } = null;
        public string Username { get; set; }
        public string Password { get; set; }
        public int PositionId { get; set; }
        public bool Status { get; set; } = true;
        
    }
}
