using Examen.Core;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
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
    public partial class Formbin : MetroForm
    {
        public Formbin()
        {
            InitializeComponent();
            LoadGrid();

        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            new InformationSotrudnik().Show(); this.Hide();
        }

        private void btn_myObyav_Click(object sender, EventArgs e)
        {
            new Mainform().Show(); this.Hide();
        }

        private void btn_allObyav_Click_1(object sender, EventArgs e)
        {
            new InformationSotrudnik().Show(); this.Hide();
        }

        private void btn_myObyav_Click_1(object sender, EventArgs e)
        {
            new Mainform().Show(); this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void Formbin_Load(object sender, EventArgs e)
        {
            Core.Database.acces = label5.Text;
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            new Infomaterial().Show(); this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
