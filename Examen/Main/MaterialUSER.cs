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
    public partial class MaterialUSER : MetroForm
    {
        public MaterialUSER()
        {
            InitializeComponent();
        }

        private void MaterialUSER_Load(object sender, EventArgs e)
        {
            DGV_Sotrudniki.DataSource = Core.Database.Query1($@"SELECT ID,
                                                                                Название,
                                                                                ТабельныйНомер AS [Табельный номер],
                                                                                Колличество AS [Колличество материала],
                                                                                Качество AS [Качество материала]
                                                                                FROM     Material ");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormbinUsers().Show(); this.Hide();
        }
    }
}
