using Examen.Animation;
using Examen.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using UiPath;
using System.IO;
using System.Data.SqlClient;

namespace Examen.Main
{
    public partial class Registration : MetroForm
    {
        public Registration()
        {
            InitializeComponent();
            Animation.Animator.Start();
            

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
            btn_reg.Click += (s, a) => RegistrationMethod();
            

        }
        private void Autorizationmethod()
        {
            new autorization().Show(); this.Hide();

        }
        
        private void RegistrationMethod()
        {
            
            if (tb_pass.Text == tb_pass2.Text)
            {
                if (tb_pass.Text.Length >= 8 && tb_pass.Text.Length <= 12)
                {
                    errLb.Visible = false;
                    
                }
                else
                {
                    errLb.Visible = true;
                    return;
                }
            }
            byte[] image = null;
            FileStream fileStream = new FileStream(imgLoc,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader= new BinaryReader(fileStream);
            image = binaryReader.ReadBytes((int)fileStream.Length);
            Core.Database.Query1($@"INSERT INTO ZayvleniyRegestration
                                                     ([LastName]   
                                                     ,[FirstName]   
                                                     ,[Patronomic]       
                                                     ,[Telefon]   
                                                     ,[Dol]     
                                                     ,[Avatar]      
                                                     ,[PasswordN]
                                                     ,[Login])
                                             VALUES
                                                   ('{tb_fam.Text}',
                                                   '{tb_nam.Text}',
                                                   '{tb_patronomic.Text}',
                                                   '{tb_tel.Text}',
                                                   '{tb_dol.Text}',
                                                   '{PictureBox.ModifierKeys.ToString()}',
                                                   '{tb_pass.Text}',
                                                   '{tb_logim.Text}')");
           
            MessageBox.Show("Ваша заявка предоставлена на рассмотрение","Внимание",MessageBoxButtons.OK);
           
          
        }

        private void btn_autorization_Click(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            RegistrationMethod();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmMain d = new frmMain(); d.Show(); 
        }

        private void egoldsGoogleTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        string imgLoc = "";
        private void yt_Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(*.BMP;*.JPEG;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPEG;*.PNG;*.GIF;*.JPG| All files(*.*)|*.*";
                ofd.InitialDirectory = @"C:\Users\HP\Pictures";
                ofd.Title = "Выберите аватар профиля";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgLoc= ofd.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_autorization_Click_1(object sender, EventArgs e)
        {
            new autorization().Show(); this.Hide();
        }

        private void btn_reg_Click_1(object sender, EventArgs e)
        {

        }
    }
}
