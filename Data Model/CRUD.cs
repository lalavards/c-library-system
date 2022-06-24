using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Library_System.Data_Model;

namespace Libray_System.Data_Model
{
    [Serializable]
    public class CRUD<c> where c : class //GENERIC - pwede mainherit ng ibang class
    {
        public static List<c> Lists = new List<c>();
        public static string FileName { get; set; } = typeof(c).Name;// Kinukuha nito yung pangalan ng Data Model, kung sino man ang mag iinherit nitong CRUD
        public static bool Add(c newData) //Means magpasa ka ng OBJECT na ang Parameter Type is User
        {
            Lists.Add(newData);
            return Serialize();
        }

        public static bool Update(c newData)
        {
       
            return Serialize();
        }

        public static bool Delete(int id) //Delete is Method
        {
            var x = Lists.First(t => t.GetType().GetProperty("Id").GetValue(t).Equals(id)); // 1.Anong type ba ang ipinasa natin kay c 2. Then, kukunin yung property nung type na yun (like "Meron bang Id si user/author/student?) 3. Get the Value 4. Icocompare siya kung equal ba yung Id sa value na pinasa 
            Lists.Remove(x);
            return Serialize();
        }

        public static List <c> Search (string name)
        {
            return Lists.Where(t => t.GetType().GetProperty("Name").GetValue(t).ToString().Contains(name)).ToList();
        }

        public static int NewId()
        {
            try
            {
                if(File.Exists(FileName))
                {
                    string id = Lists.Max(x=> x.GetType().GetProperty("Id").GetValue(x)).ToString();
                    return int.Parse(id) + 1;
                }
                return 0;
            }
            catch (Exception) { return 0; }
        }

        public static bool Serialize()
        {
            try
            {

                FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Lists);
                fs.Dispose();
                fs.Close();
                return true;


            }
            catch { return false; }
        }
        public static bool Deserialize()
        {
            try
            {
                if (System.IO.File.Exists(FileName)) // Is the file exists? if exists it will deserialize and it will be assigned to the ListofUser
                {
                    FileStream fs = new FileStream(FileName, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    Lists = ((List<c>)(formatter.Deserialize(fs)));
                    fs.Dispose();
                    fs.Close();
                    return true;

                }
                return false;
            }
            catch { return false; }


        }
    }
}
