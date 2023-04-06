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
    public partial class InformationFamilySotrudnik : MetroForm
    {
        public InformationFamilySotrudnik()
        {
            InitializeComponent();

            btn_add.Click += (s, a) => MethodAdd();
            btn_upd.Click += (s, a) => MethodUpdate();
            btn_del.Click += (s, a) => MethodDelete();
        }

        private void FamalyForm_Load(object sender, EventArgs e)
        {
            LoadGrid();


        }
        private void LoadGrid()
        {
            DGV_Family.DataSource = Core.Database.Query1($@"SELECT [ID]
                                                                 
                                                                 ,[FIO]             as 'ФИО' 
                                                                 ,[stepen_rodstva]  as 'Степень родства'
                                                                 ,[data_rojdeniya]  as 'Дата рождения'
                                                             FROM [dbo].[Family] Where FK_sotrudnik =  " + Core.Database.userId);
            DGV_Family.Columns[0].Visible = false;

            groupBox1.Text = Core.Database.username;
        }
        private void MethodAdd()
        {
            try
            {

                DGV_Family.DataSource = Core.Database.Query1($@"INSERT INTO [dbo].[Family]
                                                                                            ([FK_sotrudnik]    
                                                                                            ,[FIO]             
                                                                                            ,[stepen_rodstva]  
                                                                                            ,[data_rojdeniya]   )
                                                                                    VALUES
                                                                                 ('{Core.Database.userId}','{tb_fio.Text}','{cb_stepenrodstva.Text}','{dtp_godRojdeniya.Value.ToString()}'
                                                                                  )");


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

                DGV_Family.DataSource = Core.Database.Query1($@"UPDATE Family SET
                                                                                  FIO              = '{tb_fio.Text}',          
                                                                                  stepen_rodstva   = '{cb_stepenrodstva.Text}',      
                                                                                  data_rojdeniya   = '{dtp_godRojdeniya.Value.ToString()}'     
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

                DGV_Family.DataSource = Core.Database.Query1(@"DELETE FROM Family
                                                               WHERE ID = " + DGV_Family.CurrentRow.Cells[0].Value.ToString());


                LoadGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_Family_DoubleClick(object sender, EventArgs e)
        {
            tb_fio.Text = DGV_Family.CurrentRow.Cells[1].Value.ToString();
            cb_stepenrodstva.Text = DGV_Family.CurrentRow.Cells[2].Value.ToString();
            dtp_godRojdeniya.Value = DateTime.Parse(DGV_Family.CurrentRow.Cells[3].Value.ToString());
        }

        private void tb_exit_Click(object sender, EventArgs e)
        {
            InformationSotrudnik asd = new InformationSotrudnik(); asd.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Family_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
