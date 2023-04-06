using MetroFramework.Forms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Main
{
    public partial class HistoryForm : MetroForm
    {
        public HistoryForm()
        {
            InitializeComponent();
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            dgv_histori.DataSource = Core.Database.Query1(@"SELECT        ID AS Номер, summa AS Сумма, dataZakupki AS [Дата оформаления]
FROM            transactionOp");
            
        }
        private void CreateFormMethod()
        {
            new Main().Show();
            this.Hide();
        }
        private void histryMethod()
        {
            this.Hide();
            new HistoryForm().Show();
        }
        private void openform()
        {
            new Lichnoe().Show(); this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void headerLbl_Click(object sender, EventArgs e)
        {

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_histori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Main ds = new Main(); ds.Show(); this.Hide();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь на данной странице", "Внимение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_setting_Click_1(object sender, EventArgs e)
        {
            About a = new About(); a.Show(); this.Hide();
        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            if (dgv_histori.Rows.Count == 0)
            {
                MessageBox.Show("No data to export");
                return;
            }

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Workbook workbook = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Range chartRange;
            Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
            excel.Visible = true;

            worksheet.Cells[1, 1] = "Номер";
            worksheet.Cells[1, 2] = "Цена";
            worksheet.Cells[1, 3] = "Дата размещения";

            ChartObjects xlCharts = (ChartObjects)worksheet.ChartObjects(Type.Missing);




            for (int i = 0; i <= dgv_histori.RowCount - 1; i++)
            {
                for (int j = 0; j <= dgv_histori.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgv_histori[j, i];
                    worksheet.Cells[(i + 4) - 2, (j + 3) - 2] = cell.Value;
                }
            }
        }
    }
}

