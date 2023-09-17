using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Core
{
    public class OpenFileCommand : ICommand
    {
        private OpenFileDialog ofd;
        private PictureBox pictureBox1;

        public OpenFileCommand(OpenFileDialog ofd, PictureBox pictureBox1)
        {
            this.ofd = ofd;
            this.pictureBox1 = pictureBox1;
        }

        public void Execute()
        {
            ofd.Filter = "Image Files(*.BMP;*.JPEG;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPEG;*.PNG;*.GIF;*.JPG| All files(*.*)|*.*";
            ofd.InitialDirectory = @"C:\Users\HP\Pictures";
            ofd.Title = "Выберите аватар профиля";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imgLoc = ofd.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;
                Core.Database.image_bytes = File.ReadAllBytes(ofd.FileName);
            }
        }
    }
}
