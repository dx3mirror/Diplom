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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Examen.Main
{
    public partial class SotrudnikDopDokument : MetroForm
    {
        public SotrudnikDopDokument()
        {
            InitializeComponent();
            btn_save.Click += (s, a) => SaveMethod();
        }
        private void FormLoad()
        {
            DataTable dt = Core.Database.Query1($@"select * from AdditionalDocuments where fk = {Core.Database.userId}");
            groupBox1.Text = Core.Database.username;

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Новая запись у сотрудника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tb_SNILS.Text = dt.Rows[0][2].ToString();
                tb_POLIS.Text = dt.Rows[0][3].ToString();
                tb_INN.Text = dt.Rows[0][4].ToString();
                tb_KPP.Text = dt.Rows[0][5].ToString();
                tb_MED.Text = dt.Rows[0][6].ToString();
                tb_TRUD.Text = dt.Rows[0][7].ToString();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void SaveMethod()
        {
            DataTable dt = Core.Database.Query1($@"select * from AdditionalDocuments where fk = {Core.Database.userId}");
            if (dt.Rows.Count == 0)
            {
                Core.Database.Query1($@"INSERT INTO AdditionalDocuments
                                                                         ([fk]
                                                                         ,[SNILS]
                                                                         ,[POLIS]
                                                                         ,[INN]
                                                                         ,[KPP]
                                                                         ,[TrudKnijka]
                                                                         ,[MedKnikjka])
                                                                   VALUES
                                                                         ({Core.Database.userId},
                                                                          '{tb_SNILS.Text}',
                                                                          '{tb_POLIS.Text}',
                                                                          '{tb_INN.Text}',
                                                                          '{tb_KPP.Text}',
                                                                          '{tb_TRUD.Text}',
                                                                          '{tb_MED.Text}')");
                MessageBox.Show("Запись успешно добавлена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Core.Database.Query1($@"UPDATE AdditionalDocuments
                                                                          SET 
                                                                          
                                                                          [SNILS]                = '{tb_SNILS.Text}'
                                                                         ,[POLIS]                   = '{tb_POLIS.Text}'
                                                                         ,[INN]     = '{tb_INN.Text}'
                                                                         ,[KPP]                         = '{tb_KPP.Text}'
                                                                         ,[TrudKnijka]    = '{tb_TRUD.Text}'
                                                                         ,[MedKnikjka]            = '{tb_MED.Text}'

                                                                        WHERE fk =  {Core.Database.userId} ");
                MessageBox.Show("Запись успешно изменена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }






        }
    }
}
