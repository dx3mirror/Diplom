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
    public partial class PassportSotrudnik : MetroForm
    {
        public PassportSotrudnik()
        {
            InitializeComponent();
            btn_save.Click += (s, a) => SaveMethod();
        }

        private void PassportForm_Load(object sender, EventArgs e)
        {

            FormLoad();

        }
        private void FormLoad()
        {
            DataTable dt = Core.Database.Query1($@"select * from Passport where FK_Sotrudnik = {Core.Database.userId}");
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
                tb_adressFackt.Text = dt.Rows[0][7].ToString();


            }
        }

        private void SaveMethod()
        {
            DataTable dt = Core.Database.Query1($@"select * from Passport where FK_Sotrudnik = {Core.Database.userId}");
            if (dt.Rows.Count == 0)
            {
                Core.Database.Query1($@"INSERT INTO Passport
                                                                         ([FK_Sotrudnik]
                                                                         ,[nomer_pasporta]
                                                                         ,[datavidachi]
                                                                         ,[dataregistrachii_po_mestu]
                                                                         ,[vidan]
                                                                         ,[adressjitelstva_popasportu]
                                                                         ,[aress_fakticheskiy])
                                                                   VALUES
                                                                         ({Core.Database.userId},
                                                                          '{MasTb_pas.Text}',
                                                                          '{dtp_datavidachi.Value.ToString()}',
                                                                          '{dtp_dataregistracii.Value.ToString()}',
                                                                          '{tb_vidacha.Text}',
                                                                          '{tb_adress.Text}',
                                                                          '{tb_adressFackt.Text}')");
                MessageBox.Show("Запись успешно добавлена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Core.Database.Query1($@"UPDATE Passport
                                                                          SET 
                                                                          
                                                                          [nomer_pasporta]                = '{MasTb_pas.Text}'
                                                                         ,[datavidachi]                   = '{dtp_datavidachi.Value.ToString()}'
                                                                         ,[dataregistrachii_po_mestu]     = '{dtp_dataregistracii.Value.ToString()}'
                                                                         ,[vidan]                         = '{tb_vidacha.Text}'
                                                                         ,[adressjitelstva_popasportu]    = '{tb_adress.Text}'
                                                                         ,[aress_fakticheskiy]            = '{tb_adressFackt.Text}'

                                                                        WHERE FK_Sotrudnik =  {Core.Database.userId} ");
                MessageBox.Show("Запись успешно изменена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }






        }

        private void MasTb_pas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
