using Examen.Core;
using Examen.Models;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Main
{
    public partial class Formbin : MetroForm
    {
        public Formbin()
        {
            InitializeComponent();
            LoadGrid();
            InitFormSettings();
            _ = LoadAvatarAsync();
            btn_allObyav.Click += (s, a) => ToForm();

        }

        public void ToForm()
        {
            InformationSotrudnik information = new InformationSotrudnik();
            information.Show();
            this.Hide();
        }
        private void InitFormSettings()
        {
            // Открываем форму в полноэкранном режиме
            this.WindowState = FormWindowState.Maximized;

            // Делаем все элементы авторасширяемыми
            this.AutoSize = false;
          

            // Настраиваем внешний вид формы
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public async Task LoadAvatarAsync()
        {
            try
            {
                IDatabaseService databaseService = new DatabaseService();
                IImageService imageService = new ImageService();

                int userID = int.Parse(Core.Database.userImage);
                usersProgram userProgram = await databaseService.GetUserProgramAsync(userID);

                if (userProgram != null)
                {
                    Image avatar = imageService.LoadImageFromBytes(userProgram.Avatar);
                    pictureBox4.Image = avatar;
                    label5.Text = userProgram.Ima.ToString();


                }
            }
            catch
            {
                MessageBox.Show("У пользователя не загружен аватар");
            }

        }

        private void Formbin_Load(object sender, EventArgs e)
        {
            Core.Database.acces = label5.Text;
        }

        private void LoadGrid()
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            new Redaktor().Show();
        }
    }
}
