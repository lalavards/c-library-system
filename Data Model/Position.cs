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
    public class Position:CRUD<Position> //Position of User
    {
        public int Id { get; set; } = NewId();// Unique Id or Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
