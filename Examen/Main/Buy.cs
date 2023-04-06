using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Main
{
    public partial class Buy : MetroForm
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_opublic_Click(object sender, EventArgs e)
        {
           

        }

        private void tb_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FormbinUsers().Show(); this.Hide();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_opisanie_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLb_Click(object sender, EventArgs e)
        {

        }

        private void footerLbl_Click(object sender, EventArgs e)
        {

        }

        private void headingPic_Click(object sender, EventArgs e)
        {

        }

        private void headerLbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_opublic_Click_1(object sender, EventArgs e)
        {
            Core.Database.Query1($@"INSERT INTO Postavki
                                                             (KtoOstavilZayvku,
                                                             NaimenovaniyTovara,
                                                             Kolvo,
                                                             DataRazmejeniy)
                                                       VALUES
                                                             (  '{tb_KtoOstavilZayvku.Text}' ,
                                                                
                                                                '{tb_NaimenovaniyTovara.Text}' ,
                                                                '{tb_Kolvo.Text}',
                                                                '{DateTime.Now}')");
            

        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }
    }
}
