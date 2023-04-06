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
    public partial class sfera : MetroForm
    {
        public sfera()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sfera_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Core.Database.Query(@"SELECT ItemCode AS КодПредмета, ItemName AS НазваниеПредмета, ItemDescription AS Индификация, ItemQuantity AS Колличество, Unit AS Измерение, ItemUsed AS ПредметИспользования, ItemBalance AS Баланс, 
                  ReorderLevel AS Уровень, LastUpdated AS ПоследниеОбнавление, SupplierId AS [идентификатор поставщика], StatusId AS СтатусИД, CategoryId AS КатегорияИД, Cost AS Разходы
FROM     itemsfera");
            
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
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

            worksheet.Cells[1, 1] = "КодПредмета";
            worksheet.Cells[1, 2] = "НазваниеПредмета";
            worksheet.Cells[1, 3] = "Индификация";
            worksheet.Cells[1, 4] = "Колличество";
            worksheet.Cells[1, 6] = "ПоследниеОбнавление";
            worksheet.Cells[1, 7] = "идентификатор поставщика";
            worksheet.Cells[1, 8] = "СтатусИД";
            worksheet.Cells[1, 9] = " КатегорияИД";
            worksheet.Cells[1, 10] = "Разходы";
          

            ChartObjects xlCharts = (ChartObjects)worksheet.ChartObjects(Type.Missing);




            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    worksheet.Cells[(i + 4) - 2, (j + 3) - 2] = cell.Value;
                }
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {
            new postavjiki().Show(); this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void btn_myObyav_Click(object sender, EventArgs e)
        {
            new graal().Show(); this.Hide();
        }

        private void btn_myObyav_Click_1(object sender, EventArgs e)
        {
            new graal().Show(); this.Hide();
        }

        private void btn_setting_Click_1(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь на данной странице", "Внимение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
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

            worksheet.Cells[1, 1] = "КодПредмета";
            worksheet.Cells[1, 2] = "НазваниеПредмета";
            worksheet.Cells[1, 3] = "Индификация";
            worksheet.Cells[1, 4] = "Колличество";
            worksheet.Cells[1, 6] = "ПоследниеОбнавление";
            worksheet.Cells[1, 7] = "идентификатор поставщика";
            worksheet.Cells[1, 8] = "СтатусИД";
            worksheet.Cells[1, 9] = " КатегорияИД";
            worksheet.Cells[1, 10] = "Разходы";


            ChartObjects xlCharts = (ChartObjects)worksheet.ChartObjects(Type.Missing);




            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    worksheet.Cells[(i + 4) - 2, (j + 3) - 2] = cell.Value;
                }
            }
        }
    }
    
}
