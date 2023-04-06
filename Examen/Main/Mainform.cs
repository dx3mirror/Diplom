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
    public partial class Mainform : MetroForm
    {
        public Mainform()
        {
            InitializeComponent();
        }

       

        private void btn_createObyav_Click(object sender, EventArgs e)
        {

        }

        private void footerLbl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new postavjiki().Show(); this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Main().Show(); this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Buy().Show(); this.Hide();
        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь на данной странице", "Внимение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_myObyav_Click(object sender, EventArgs e)
        {
            Lichnoe hdd = new Lichnoe(); hdd.Show(); this.Hide();
        }

        private void btn_createObyav_Click_1(object sender, EventArgs e)
        {
            Main ds = new Main(); ds.Show(); this.Hide();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            HistoryForm aa = new HistoryForm(); aa.Show(); this.Hide();
        }

        private void btn_setting_Click_1(object sender, EventArgs e)
        {
            About a = new About(); a.Show(); this.Hide();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
