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
    public partial class aboutUsers : MetroForm
    {
        public aboutUsers()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа идеальна", "Не делай глупостей", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormbinUsers fd = new FormbinUsers();  fd.Show(); this.Hide();
        }

        private void aboutUsers_Load(object sender, EventArgs e)
        {

        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            FormbinUsers fd = new FormbinUsers(); fd.Show(); this.Hide();
        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа идеальна", "Не делай глупостей", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
