using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_System.Data_Model;
namespace Libray_System.Views
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position_ { get; set; }
        public bool Active { get; set; }

        public static List<Users> View = new List<Users>(); // Actual Viewing of data

        public static List<Users> RefreshMethod()
        {
            var user = User.Lists;
            var pos = Position.Lists;

            //Language Integrated Query
            var newEntity = from u in user
                            join p in pos on u.PositionId equals p.Id
                            

                            select new Users
                            {
                                Id = u.Id,
                                Name = u.Name,
                                Position_ = p.Name,
                                Active = u.Status


                            };
             
            View = newEntity.ToList();
            return View;

        }

        public static List<Users> SearchView(string value)
        {
            try
            {
                return View.Where(d => d.Name.Contains(value)).ToList();
            }
            catch { return null; }

        }
    }
}
