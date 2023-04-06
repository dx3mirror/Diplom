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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            dgv_histori.DataSource = Core.Database.Query(@"SELECT        operations.id AS Номер, operations.money AS Цена, ads.expDate AS [Дата размещения]
                                                            FROM            operations INNER JOIN
                         ads ON operations.id = ads.id");
            btn_history.Click += (s, a) => histryMethod();
            btn_myObyav.Click += (s, a) => openform();
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
