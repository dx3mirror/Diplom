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
    public partial class InformationObrozovaniySotrudnik : MetroForm
    {
        public InformationObrozovaniySotrudnik()
        {
            InitializeComponent();
            btn_add.Click += (s, a) => MethodAdd();
            btn_upd.Click += (s, a) => MethodUpdate();
            btn_del.Click += (s, a) => MethodDelete();
        }

        private void ObrazovanieForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            DGV_Obrazovanie.DataSource = Core.Database.Query1($@"SELECT        ID_OB, 
                                                                                  obrazovanie AS Образование,
                                                                                  nazvanieuchrejdeniya AS [Наименование образовательного учреждения],
                                                                                  kvalifikachiyapoObrazovaniyu AS [Квалификация по документу об образовании], 
                                                                                  nazvanieuchrejdeniya2 AS [Наименование образовательного учреждения],
                                                                                  kvalifikachiyapoObrazovaniyu2 AS [Квалификация по документу об образовании], 
                                                                                  poslevuzovoe AS [Послевузовское профессиональное образование], 
                                                                                  professiaOsnova AS [Профессия основная], professiaDopolnitel AS [Профессия другая]
                                                                                  FROM            Obrazovanie 
                                                                                  Where fk_kod_sotrudnika = " + Core.Database.userId);
            DGV_Obrazovanie.Columns[0].Visible = false;
            groupBox1.Text = Core.Database.username;
            
        }
        private void MethodAdd()
        {
            try
            {

                DGV_Obrazovanie.DataSource = Core.Database.Query1($@"INSERT INTO Obrazovanie
                                                                                      ([fk_kod_sotrudnika]
                                                                                      ,[obrazovanie]
                                                                                      ,[nazvanieuchrejdeniya]
                                                                                      ,[kvalifikachiyapoObrazovaniyu]
                                                                                      ,[nazvanieuchrejdeniya2]
                                                                                      ,[kvalifikachiyapoObrazovaniyu2]
                                                                                      ,[poslevuzovoe]
                                                                                      ,[professiaOsnova]
                                                                                      ,[professiaDopolnitel])
                                                                                VALUES
                                                                                      ('{Core.Database.userId}',
                                                                                       '{tb_obrazovanie.Text}',
                                                                                       '{tb_nazvanieUchrejdenia.Text}',
                                                                                       '{tb_kvalifikaziya.Text}',
                                                                                       '{tb_nazvanieUchrejdenia2.Text}',
                                                                                       '{tb_kvalifikaziya2.Text}',
                                                                                       '{tb_vuz.Text}',
                                                                                       '{tb_professiyaOsnovnaya.Text}',
                                                                                       '{tb_professiaDrugaya.Text}')");


                LoadGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void MethodUpdate()
        {
            try
            {

                DGV_Obrazovanie.DataSource = Core.Database.Query1($@"UPDATE [dbo].[Obrazovanie]
                                                                              SET [obrazovanie]                   = '{tb_obrazovanie.Text}'
                                                                                 ,[nazvanieuchrejdeniya]          = '{tb_nazvanieUchrejdenia.Text}'
                                                                                 ,[kvalifikachiyapoObrazovaniyu]  = '{tb_kvalifikaziya.Text}'
                                                                                 ,[nazvanieuchrejdeniya2]         = '{tb_nazvanieUchrejdenia2.Text}'
                                                                                 ,[kvalifikachiyapoObrazovaniyu2] = '{tb_kvalifikaziya2.Text}'
                                                                                 ,[poslevuzovoe]                  = '{tb_vuz.Text}'
                                                                                 ,[professiaOsnova]               = '{tb_professiyaOsnovnaya.Text}'
                                                                                 ,[professiaDopolnitel]           = '{tb_professiaDrugaya.Text}'
                                                                            WHERE ID_OB = " + DGV_Obrazovanie.CurrentRow.Cells[0].Value.ToString());


                LoadGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MethodDelete()
        {
            try
            {

                DGV_Obrazovanie.DataSource = Core.Database.Query1(@"DELETE FROM Obrazovanie
                                                               WHERE ID_OB = " + DGV_Obrazovanie.CurrentRow.Cells[0].Value.ToString());


                LoadGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_Obrazovanie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_obrazovanie.Text = DGV_Obrazovanie.CurrentRow.Cells[1].Value.ToString();
            tb_nazvanieUchrejdenia.Text = DGV_Obrazovanie.CurrentRow.Cells[2].Value.ToString();
            tb_kvalifikaziya.Text = DGV_Obrazovanie.CurrentRow.Cells[3].Value.ToString();
            tb_nazvanieUchrejdenia2.Text = DGV_Obrazovanie.CurrentRow.Cells[4].Value.ToString();
            tb_kvalifikaziya2.Text = DGV_Obrazovanie.CurrentRow.Cells[5].Value.ToString();
            tb_vuz.Text = DGV_Obrazovanie.CurrentRow.Cells[6].Value.ToString();
            tb_professiyaOsnovnaya.Text = DGV_Obrazovanie.CurrentRow.Cells[7].Value.ToString();
            tb_professiaDrugaya.Text = DGV_Obrazovanie.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void tb_exit_Click(object sender, EventArgs e)
        {
            InformationSotrudnik ad = new InformationSotrudnik(); ad.Show(); this.Hide();
        }
    }
    
}
