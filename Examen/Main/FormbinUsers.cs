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
    public partial class FormbinUsers : MetroForm
    {
        public FormbinUsers()
        {
            InitializeComponent();
        }

       

        private void btn_setting_Click(object sender, EventArgs e)
        {
            aboutUsers j = new aboutUsers(); j.Show(); this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            GraalUsers gr = new GraalUsers(); gr.Show(); this.Hide();
        }

        private void btn_myObyav_Click_1(object sender, EventArgs e)
        {
            Buy zk = new Buy(); zk.Show(); this.Hide();
        }

        private void btn_setting_Click_1(object sender, EventArgs e)
        {
            aboutUsers j = new aboutUsers(); j.Show(); this.Hide();
        }

        private void FormbinUsers_Load(object sender, EventArgs e)
        {

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            new MaterialUSER().Show();
        }
    }
}
