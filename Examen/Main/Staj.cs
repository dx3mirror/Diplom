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
    public partial class Staj : MetroForm
    {
        public Staj()
        {
            InitializeComponent();
            btn_save.Click += (s, a) => SaveMethod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        private void FormLoad()
        {
            DataTable dt = Core.Database.Query1($@"select * from Experience where FK_Sotrudnik = {Core.Database.userId}");
            groupBox4.Text = Core.Database.username;

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Новая запись у сотрудника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tb_ObshiyDay.Text = dt.Rows[0][2].ToString();
                tb_ObshiyMonth.Text = dt.Rows[0][3].ToString();
                tb_ObshiyYear.Text = dt.Rows[0][4].ToString();
                tb_NeprerivniyDay.Text = dt.Rows[0][5].ToString();
                tb_NeprerivniyMonth.Text = dt.Rows[0][6].ToString();
                tb_NeprerivniyYear.Text = dt.Rows[0][7].ToString();
                tb_PravoDay.Text = dt.Rows[0][8].ToString();
                tb_PravoMonth.Text = dt.Rows[0][9].ToString();
                tb_PravoYear.Text = dt.Rows[0][10].ToString();
                dtp_stajRaboti.Value = DateTime.Parse(dt.Rows[0][11].ToString());
            }
        }
        private void SaveMethod()
        {
            DataTable dt = Core.Database.Query1($@"select * from Experience where FK_Sotrudnik = {Core.Database.userId}");
            if (dt.Rows.Count == 0)
            {
                Core.Database.Query1($@"INSERT INTO [dbo].[Experience]
                                                                         ([FK_Sotrudnik]
                                                                         ,[obchyi_day]
                                                                         ,[obchyi_month]
                                                                         ,[obchyi_year]
                                                                         ,[nepreryvniy_day]
                                                                         ,[nepreryvniy_month]
                                                                         ,[nepreryvniy_year]
                                                                         ,[vislugalet_day]
                                                                         ,[vislugalet_month]
                                                                         ,[vislugalet_year]
                                                                         ,[stajrabotyposostoyaniyna])
                                                                   VALUES
                                                                         ({Core.Database.userId},
                                                                          '{tb_ObshiyDay.Text}',
                                                                          '{tb_ObshiyMonth.Text}',
                                                                          '{tb_ObshiyYear.Text}',
                                                                          '{tb_NeprerivniyDay.Text}',
                                                                          '{tb_NeprerivniyMonth.Text}',
                                                                          '{tb_NeprerivniyYear.Text}',
                                                                          '{tb_PravoDay.Text}',
                                                                          '{tb_PravoMonth.Text}',
                                                                          '{tb_PravoYear.Text}',
                                                                          '{dtp_stajRaboti.Value.ToString()}')");

            }
            else
            {
                Core.Database.Query($@"UPDATE Experience
                                                                          SET 
                                                                              [obchyi_day]           = '{tb_ObshiyDay.Text}'
                                                                             ,[obchyi_month]         = '{tb_ObshiyMonth.Text}'
                                                                             ,[obchyi_year]          = '{tb_ObshiyYear.Text}'
                                                                             ,[nepreryvniy_day]      = '{tb_NeprerivniyDay.Text}'
                                                                             ,[nepreryvniy_month]    = '{tb_NeprerivniyMonth.Text}'
                                                                             ,[nepreryvniy_year]     = '{tb_NeprerivniyYear.Text}'
                                                                             ,[vislugalet_day]       = '{tb_PravoDay.Text}'
                                                                             ,[vislugalet_month]     = '{tb_PravoMonth.Text}'
                                                                             ,[vislugalet_year]      = '{tb_PravoYear.Text}'
                                                                             ,[stajrabotyposostoyaniyna] =   '{dtp_stajRaboti.Value.ToString()}'

                                                                        WHERE FK_Sotrudnik =  {Core.Database.userId} ");

            }

        }
    }
}
