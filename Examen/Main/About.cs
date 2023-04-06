using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Examen.Main
{
    public partial class About : MetroForm
    {
        public About()
        {
            InitializeComponent();
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            new Mainform().Show();
            this.Hide();
        }

        private void btn_myObyav_Click(object sender, EventArgs e)
        {
            new Lichnoe().Show();
            this.Hide();
        }

        private void btn_createObyav_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            new HistoryForm().Show();
            this.Hide();
        }

        private void btn_allObyav_Click_1(object sender, EventArgs e)
        {
            Mainform hd = new Mainform(); hd.Show(); this.Hide();
        }

        private void btn_myObyav_Click_1(object sender, EventArgs e)
        {
            Lichnoe hdd = new Lichnoe(); hdd.Show(); this.Hide();
        }

        private void btn_createObyav_Click_1(object sender, EventArgs e)
        {
            Main ds = new Main(); ds.Show(); this.Hide();
        }

        private void btn_history_Click_1(object sender, EventArgs e)
        {
            HistoryForm aa = new HistoryForm(); aa.Show(); this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь на данной странице", "Внимение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
