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
    public partial class Lichnoe : Form
    {
        public Lichnoe()
        {
            InitializeComponent();
        }

        private void Lichnoe_Load(object sender, EventArgs e)
        {
            dgv_moye.DataSource = Core.Database.Query(@"SELECT        ads.name AS Название, ads.image AS изображение, ads.decscription AS Описание, operations.money AS Цена, operations.date AS Срок
                                                                        FROM            ads INNER JOIN
                                                                        operations ON ads.id = operations.id");
            btn_myObyav.Click += (s, a) => openform();
            btn_history.Click += (s, a) => histryMethod();
            btn_createObyav.Click += (s, a) => CreateFormMethod();

        }
        private void CreateFormMethod()
        {
            new Main().Show();
            this.Hide();
        }

        private void histryMethod()
        {
            this.Hide();
            new HistoryForm().Show();
        }
        private void openform()
        {
            new Lichnoe().Show(); this.Hide();

        }
    }
}
