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
    public partial class WarUchet : MetroForm
    {
        public WarUchet()
        {
            InitializeComponent();
            btn_add.Click += (s, a) => MethodAdd();
            btn_upd.Click += (s, a) => MethodUpdate();
            btn_del.Click += (s, a) => MethodDelete();
        }

        private void WarUchet_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            DGV_Family.DataSource = Core.Database.Query1($@"SELECT        ID, 
                                                                            Kategorya AS [Категория запаса],
                                                                            Zvanie AS [Воинское звание],
                                                                            Sostav AS Состав, kod_VUS AS [Код по ВУС],
                                                                            Sostoyanie_voinskogo AS [Воинский учёт],
                                                                            Nazvanie_komisariata AS [Название коммисариата], 
                                                                            Kategoria AS Категория FROM     Waruchet
                                                                            Where fk_sotrudnik = " + Core.Database.userId);
            DGV_Family.Columns[0].Visible = false;
            groupBox1.Text = Core.Database.username;
        }
        private void MethodAdd()
        {
            try
            {

                DGV_Family.DataSource = Core.Database.Query1($@"INSERT INTO Waruchet
                                                                                      ([fk_sotrudnik]
                                                                                      ,[Kategorya]
                                                                                      ,[Zvanie]
                                                                                      ,[Sostav]
                                                                                      ,[kod_VUS]
                                                                                      ,[Sostoyanie_voinskogo]
                                                                                      ,[Nazvanie_komisariata]
                                                                                      ,[Kategoria])
                                                                                VALUES
                                                                                      ('{Core.Database.userId}',
                                                                                       '{cb_stepenrodstva.Text}',
                                                                                       '{tb_fio.Text}',
                                                                                       '{tb_sostav.Text}',
                                                                                       '{tb_VUS.Text}',
                                                                                       '{cb_UCHET.Text}',
                                                                                       '{tb_voinskiy.Text}',
                                                                                       '{tb_category.Text}')");


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

                DGV_Family.DataSource = Core.Database.Query1($@"UPDATE [dbo].[Waruchet]
                                                                              SET [Kategorya]                   = '{cb_stepenrodstva.Text}'
                                                                                 ,[Zvanie]          = '{tb_fio.Text}'
                                                                                 ,[Sostav]  = '{tb_sostav.Text}'
                                                                                 ,[kod_VUS]         = '{tb_VUS.Text}'
                                                                                 ,[Sostoyanie_voinskogo] = '{cb_UCHET.Text}'
                                                                                 ,[Nazvanie_komisariata]                  = '{tb_voinskiy.Text}'
                                                                                 ,[Kategoria]               = '{tb_category.Text}'
                                                                                 
                                                                            WHERE ID = " + DGV_Family.CurrentRow.Cells[0].Value.ToString());


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

                DGV_Family.DataSource = Core.Database.Query1(@"DELETE FROM Waruchet
                                                               WHERE ID = " + DGV_Family.CurrentRow.Cells[0].Value.ToString());


                LoadGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
