using MetroFramework.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Main
{
    public partial class autorization : MetroForm
    {
        public autorization()
        {
            InitializeComponent();
         




        }

        private void autorization_Load(object sender, EventArgs e)
        {
            
            tb_pass.UseSystemPasswordChar = true;
            
            
        }

        private void tb_log_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click_1(object sender, EventArgs e)
        {
            
        }

        private void headerLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void iconPic_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }

        private void footerLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void usernameLb_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_pass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void forgetLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registration().Show(); this.Hide();
        }

        private void headingPic_Click_1(object sender, EventArgs e)
        {

        }

        private void passwordLb_Click_1(object sender, EventArgs e)
        {

        }

        private void errLb_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            
            DataTable dt = Core.Database.Query1($@"SELECT * FROM usersProgram WHERE (loginI = N'{tb_log.Text}') AND (PasI = N'{tb_pass.Text}')");
            

            if (dt.Rows.Count != 1)
            {
                errLb.Visible = Enabled;
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Core.Database.acces = dt.Rows[0][3].ToString();
               
                switch (dt.Rows[0][3].ToString())
                {
                    case "Administration":
                        new Formbin().Show(); this.Hide();
                        Core.Database.userId = 1;
                        Core.Database.Query1($@"INSERT INTO Transactionprogram
                                                                         (
                                                                         [DateLog],
                                                                         [NameLog])
                                                                   VALUES
                                                                         (
                                                                          '{DateTime.Now}',
                                                                          '{tb_log.Text}')");
                        break;
                    case "User":
                        new FormbinUsers().Show(); this.Hide();
                        Core.Database.userId = 2;
                        Core.Database.Query1($@"INSERT INTO Transactionprogram
                                                                         (
                                                                         [DateLog],
                                                                         [NameLog])
                                                                   VALUES
                                                                         (
                                                                          '{DateTime.Now}',
                                                                          '{tb_log.Text}')");
                        break;
                    case "Поставщик":
                        new Formbin().Show(); this.Hide();
                        Core.Database.userId = 3;
                        break;

                }
            }
        }
    }
}
