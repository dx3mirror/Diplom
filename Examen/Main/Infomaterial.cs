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
    public partial class Infomaterial : MetroForm
    {
        public Infomaterial()
        {
            InitializeComponent();
            LoadGrid();
            btn_insetr.Click += (s, a) => MethodAdd();
            btn_Update.Click += (s, a) => MethodUpdate();
        }
        private void btnEnabled()
        {
            if (Core.Database.userId == 0)
            {



                btn_sklad.Enabled = false;
            }
            else
            {

                btn_sklad.Enabled = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadGrid(string customSelect = null)
        {



            DGV_Sotrudniki.DataSource = Core.Database.Query1(     $@"SELECT ID,
                                                                                Название,
                                                                                ТабельныйНомер AS [Табельный номер],
                                                                                Колличество AS [Колличество материала],
                                                                                Качество AS [Качество материала]
                                                                                FROM     Material ");

                
           

            


        }

        private void MethodAdd()
        {
            try
            {

                DGV_Sotrudniki.DataSource = Core.Database.Query1($@"INSERT INTO Material
                                                                                            ( [Название]        
                                                                                             ,[ТабельныйНомер]             
                                                                                             ,[Колличество]      
                                                                                             ,[Качество])
                                                                    VALUES
                                                                                 ('{tb_naz.Text}','{btn_tabNom.Text}','{btn_KOL.Text}',
                                                                                   '{btn_kah.Text}')");


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

                DGV_Sotrudniki.DataSource = Core.Database.Query1($@"UPDATE Material SET
                                                                                             Название         = '{tb_naz.Text}'
                                                                                             ,ТабельныйНомер             = '{btn_tabNom.Text}'
                                                                                             ,Колличество      = '{btn_KOL.Text}'
                                                                                             ,Качество         = '{btn_kah.Text}'
                                                                                            
                                                                    WHERE ID = " + DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString());


                LoadGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_Sotrudniki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Core.Database.userId = (int)DGV_Sotrudniki.CurrentRow.Cells[0].Value;
            Core.Database.username = DGV_Sotrudniki.CurrentRow.Cells[1].Value.ToString() + " " + DGV_Sotrudniki.CurrentRow.Cells[2].Value.ToString() + " " + DGV_Sotrudniki.CurrentRow.Cells[3].Value.ToString();

            btnEnabled();
        }

        private void DGV_Sotrudniki_DoubleClick(object sender, EventArgs e)
        {
            tb_naz.Text = DGV_Sotrudniki.CurrentRow.Cells[1].Value.ToString();
            btn_tabNom.Text = DGV_Sotrudniki.CurrentRow.Cells[2].Value.ToString();
            btn_KOL.Text = DGV_Sotrudniki.CurrentRow.Cells[3].Value.ToString();
            btn_kah.Text = DGV_Sotrudniki.CurrentRow.Cells[4].Value.ToString();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            new Formbin().Show(); this.Hide();
        }

        private void btn_sklad_Click(object sender, EventArgs e)
        {
            new MaterialSklad().Show(); 
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            DGV_Sotrudniki.DataSource = Core.Database.Query1($@" Delete from usersProgram   
                                                                    WHERE ID_dol = " + DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString());
            LoadGrid(); 
        }
    }
}
