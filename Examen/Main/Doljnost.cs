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
    public partial class Doljnost : MetroForm
    {
        public Doljnost()
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
            DataTable dt = Core.Database.Query1($@"select * from doljnost where fk_kod_sotrudnik = {Core.Database.userId}");
            groupBox1.Text = Core.Database.username;

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Новая запись у сотрудника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MasTb_pas.Text = dt.Rows[0][2].ToString();
                dtp_datavidachi.Value = DateTime.Parse(dt.Rows[0][3].ToString());
                dtp_dataregistracii.Value = DateTime.Parse(dt.Rows[0][4].ToString());
                tb_vidacha.Text = dt.Rows[0][5].ToString();
                tb_adress.Text = dt.Rows[0][6].ToString();
                


            }
        }
        private void SaveMethod()
        {
            DataTable dt = Core.Database.Query1($@"select * from doljnost where fk_kod_sotrudnik = {Core.Database.userId}");
            if (dt.Rows.Count == 0)
            {
                Core.Database.Query1($@"INSERT INTO doljnost
                                                                         ([fk_kod_sotrudnik]
                                                                         ,[naimenoviy_doljnosti]
                                                                         ,[s_kogo]
                                                                         ,[po_kokoe]
                                                                         ,[kol_vo]
                                                                         ,[otvetstveniy])
                                                                   VALUES
                                                                         ({Core.Database.userId},
                                                                          '{MasTb_pas.Text}',
                                                                          '{dtp_datavidachi.Value.ToString()}',
                                                                          '{dtp_dataregistracii.Value.ToString()}',
                                                                          '{tb_vidacha.Text}',
                                                                          '{tb_adress.Text}')");
                MessageBox.Show("Запись успешно добавлена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Core.Database.Query1($@"UPDATE doljnost
                                                                          SET 
                                                                          
                                                                          [naimenoviy_doljnosti]                = '{MasTb_pas.Text}'
                                                                         ,[s_kogo]                   = '{dtp_datavidachi.Value.ToString()}'
                                                                         ,[po_kokoe]     = '{dtp_dataregistracii.Value.ToString()}'
                                                                         ,[kol_vo]                         = '{tb_vidacha.Text}'
                                                                         ,[otvetstveniy]    = '{tb_adress.Text}'
                                                                         

                                                                        WHERE FK_Sotrudnik =  {Core.Database.userId} ");
                MessageBox.Show("Запись успешно изменена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }






        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
