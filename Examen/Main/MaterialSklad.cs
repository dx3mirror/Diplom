using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Examen.Main
{
    public partial class MaterialSklad : MetroForm
    {
        public MaterialSklad()
        {
            InitializeComponent();
            btn_save.Click += (s, a) => SaveMethod();
        }

        private void FormLoad()
        {
            DataTable dt = Core.Database.Query1($@"select * from Sklad where fk_kod_material = {Core.Database.userId}");
            groupBox1.Text = Core.Database.username;

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Новая запись у сотрудника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
            }
        }

        private void LoadGrid()
        {
            DGV_Sotrudniki.DataSource = Core.Database.Query1($@"SELECT ID,
                                                                        fk_kod_material,
                                                                        НомерСклада AS [Номер склада],
                                                                        ДатаПрибытияТовара AS [Дата прибытия материала],
                                                                        ОсобыеУсловияХранения AS [Особые условия хранения]
                                                             FROM     Sklad Where fk_kod_material = " + Core.Database.userId);
            DGV_Sotrudniki.Columns[0].Visible = false;
            DGV_Sotrudniki.Columns[1].Visible = false;
            groupBox1.Text = Core.Database.username;
        }

        private void MaterialSklad_Load(object sender, EventArgs e)
        {
            FormLoad();
            LoadGrid();
        }
        private void SaveMethod()
        {
            DataTable dt = Core.Database.Query1($@"select * from Sklad where fk_kod_material = {Core.Database.userId}");


            Core.Database.Query1($@"INSERT INTO Sklad
                                                                         ([fk_kod_material]
                                                                         ,[НомерСклада]
                                                                         ,[ДатаПрибытияТовара]
                                                                         ,[ОсобыеУсловияХранения])
                                                                   VALUES
                                                                         ({Core.Database.userId},
                                                                         '{tb_nomer.Text}', 
                                                                        '{dtp_datavidachi.Value.ToString()}',  
                                                                          '{btn_xraneniy.Text}')");
            MessageBox.Show("Запись успешно добавлена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadGrid();

        }
    }
}