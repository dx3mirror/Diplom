using Examen.Animation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Examen.Core;

namespace Examen.Main
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            Animator.Start();
            bunifuButton1.Click += (s,a) => OpenImageBox();
            btn_autorization.Click += btn_autorization_Click_1;


        }

        private void Registration_Load(object sender, EventArgs e)
        {
           
            btn_reg.Click += (s, a) => RegistrationMethod();
           
        }

        

        private void RegistrationMethod()
        {
            try
            {
                
                    var registrationService = new RegistrationService(tb_logim.Text,
                        tb_pass.Text,
                        tb_pass2.Text,
                        tb_fam.Text,
                        tb_dol.Text,
                        tb_nam.Text,
                        tb_patronomic.Text);
                    registrationService.RegistrationMethod();
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitFormSettings()
        {
            // Открываем форму в полноэкранном режиме
            this.WindowState = FormWindowState.Maximized;

            // Делаем все элементы авторасширяемыми
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;

            // Настраиваем внешний вид формы
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void OpenImageBox()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                PictureBox pictureBox1 = this.pictureBox1;

                ICommand command = new OpenFileCommand(ofd, pictureBox1);
                command.Execute();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            OpenImageBox();
        }


        private void btn_autorization_Click_1(object sender, EventArgs e)
        {
            new autorization().Show(); this.Hide();
        }

        private void btn_reg_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
