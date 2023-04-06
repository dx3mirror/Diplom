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
    public partial class postavjiki : MetroForm
    {
        public postavjiki()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Mainform().Show(); this.Hide();
        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            new sfera().Show(); this.Hide();
        }

        private void btn_myObyav_Click(object sender, EventArgs e)
        {
            new graal().Show(); this.Hide();
        }

        private void btn_allObyav_Click_1(object sender, EventArgs e)
        {
            new sfera().Show(); this.Hide();
        }

        private void btn_myObyav_Click_1(object sender, EventArgs e)
        {
            new graal().Show(); this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            new Mainform().Show(); this.Hide();
        }

        private void postavjiki_Load(object sender, EventArgs e)
        {

        }
    }
}
