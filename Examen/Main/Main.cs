using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace Examen.Main
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            btn_opublic.Click += (s, a) => MethodUpdate();
            btn_Pehat.Click+= (s, a) => MethodPehat();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadGrid();
            label2.Visible = false;
            
        }
        private void LoadGrid(string customSelect = null)
        {
            if (customSelect == null)
            {
                customSelect =
                  $@"SELECT        ID, KtoOstavilZayvku AS Отправитель, NaimenovaniyTovara AS [Наименование товара],  Kolvo AS [Колличество товара], Cena AS [Цена товара], 
                         Summa AS Сумма, INN AS ИНН, KPP AS КПП, Poluhatel AS Получатель, Bank AS Банк, Adress AS [Адресс доставки], NomerCheta AS [Номер счёта], Rukovoditelpredpriytiy AS [Руководитель предприятия], 
                         Buhalter AS Бухалтер, DataRazmejeniy AS [Дата размещения], Status AS Статус
FROM            Postavki";


                if (checkBox_deleted.Checked)
                    customSelect += " where Status = 'Рассмотрен'";
                else
                {
                    customSelect += " where Status = 'Не рассмотрена'";
                }
            }
            System.Data.DataTable tb = Core.Database.Query1(customSelect);

            if (tb != null)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    if ((string)dr.ItemArray[15] == "Status")
                        dr["Status"] = "(Не рассмотрена) " + dr["Status"];
                }


                dataGridView1.DataSource = tb;
                dataGridView1.Columns[0].Visible = false;
               

            };


        }
        private void MethodUpdate()
        {
            try
            {

                dataGridView1.DataSource = Core.Database.Query1($@"UPDATE [dbo].[Postavki]
                                                                              SET [KtoOstavilZayvku]                   = '{btn_KtoOstavilZayvku.Text}'
                                                                                 ,[NaimenovaniyTovara]          = '{btn_NaimenovaniyTovara.Text}'
                                                                                 
                                                                                 ,[Kolvo]               = '{tb_Kolvo.Text}'
                                                                                 ,[Cena]           = '{tb_Cena.Text}'
                                                                                 ,[Summa]         = '{tb_Summa.Text}'
                                                                                 ,[INN] = '{tb_INN.Text}'
                                                                                 ,[Poluhatel] = '{tb_Poluhatel.Text}'   
                                                                                 ,[KPP]                  = '{tb_KPP.Text}'
                                                                                 ,[Bank]               = '{tb_Bank.Text}'
                                                                                 ,[Adress]           = '{tb_Adress.Text}'
                                                                                 ,[NomerCheta]         = '{tb_Cheta.Text}'
                                                                                 ,[Rukovoditelpredpriytiy] = '{tb_Rukovoditelpredpriytiy.Text}'
                                                                                 ,[Buhalter]                  = '{tb_Buhalter.Text}'
                                                                                 ,[DataRazmejeniy]               = '{dtp_DataRazmejeniy.Value.ToString()}'
                                                                                 ,[Status]           = '{tb_Status.Text}'

                                                                            WHERE ID = " + dataGridView1.CurrentRow.Cells[0].Value.ToString());

                dataGridView1.DataSource = Core.Database.Query1($@"INSERT INTO transactionOp
                                                                                            ( [summa]        
                                                                                             ,[dataZakupki] )        
                                                        VALUES
                                                                                 ('{tb_Summa.Text}',
                                                                                  '{dtp_DataRazmejeniy.Value.ToString()}')");


                LoadGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MethodPehat()
        {
            Print.Zayvka(dataGridView1);
        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            Mainform hd = new Mainform(); hd.Show(); this.Hide();
        }

        private void btn_myObyav_Click(object sender, EventArgs e)
        {
            Lichnoe hdd = new Lichnoe(); hdd.Show(); this.Hide();
        }

        private void btn_createObyav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь на данной странице", "Внимение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_history_Click_1(object sender, EventArgs e)
        {
            HistoryForm aa = new HistoryForm(); aa.Show(); this.Hide();
        }

        private void btn_setting_Click_1(object sender, EventArgs e)
        {
            About a = new About(); a.Show(); this.Hide();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btn_KtoOstavilZayvku.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            btn_NaimenovaniyTovara.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tb_Kolvo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tb_Cena.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tb_Summa.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_INN.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tb_KPP.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tb_Bank.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tb_Adress.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tb_Cheta.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            dtp_DataRazmejeniy.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[14].Value.ToString());


        }

        private void checkBox_deleted_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            label2.Visible = Enabled;
           
            double FirstValue = Convert.ToDouble(tb_Kolvo.Text);
            double Last = Convert.ToDouble(tb_Cena.Text);
            double result = FirstValue * Last;
            label2.Text = Convert.ToString(result);
            tb_Summa.Text = Convert.ToString(result);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
