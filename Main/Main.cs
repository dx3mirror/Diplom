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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btn_opublic.Click += (s, a) => OpublicMethod();
            btn_myObyav.Click += (s, a) => openform();
            btn_history.Click += (s, a) => histryMethod();
            btn_createObyav.Click += (s, a) => CreateFormMethod();
            LoadComboBox();
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
        private void ClearAll()
        {
            tb_name.Clear();
            tb_opisanie.Clear();
            tb_name.Clear();
            tb_date.Clear();

        }
        private void openform()
        {
            new Lichnoe().Show(); this.Hide();

        }
        private void OpublicMethod()
        {
            Core.Database.Query($@"INSERT INTO ads
                                                             (name         ,
                                                             image        ,
                                                             decscription ,
                                                             userid,
                                                             expDate)
                                                       VALUES
                                                             (  '{tb_name.Text}' ,
                                                                'no' ,
                                                                '{tb_opisanie.Text}' ,
                                                                '{Core.Database.userId}',
                                                                '{DateTime.Now}')");
            Core.Database.Query($@"insert into operations 
                                                                (userid
                                                                 ,money
                                                                 ,date)
                                                                values
                                                                ('{Core.Database.userId}',
                                                                 '{tb_price.Text}',
                                                                 '{tb_date.Text}')");
            MessageBox.Show("Данные успешно введены", "Внимание", MessageBoxButtons.OK);

             ClearAll();
        }
        private void LoadComboBox()
        {
            DataTable table = Core.Database.Query(@" select * from categories");

            for (int i = 0; i < table.Rows.Count; i++)
            {
                cb_categor.Items.Add(table.Rows[i][1].ToString());
            }
        }
    }
}
