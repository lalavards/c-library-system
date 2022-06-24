using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    internal class Utilities
    {
        //Purpose: Open DialogBox then Pick an Image
        public static string BrowseImage(PictureBox pb) 
            //Ang naopen niyang image ay iseset niya into picture box
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG Files (*.jpeg)|*jpg|PNG Files (*.png)|*png| JPG Files (*.jpg)|*jpg| GIF Files (*.gif) |*.gif| All Files (*.*)| *.* ";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dialog.FileName.ToString();
                    pb.ImageLocation = imagePath; //Yung location na makukuha naten, yun yung Image na iaassign natin kay PictureBox
                    dialog.Dispose();
                    return imagePath;

                }
                else return null;

            }
            catch { return null; }
        }
    }
}
