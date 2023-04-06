using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;

using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;

namespace Examen.Main
{
    public partial class Lichnoe : MetroForm
    {
        public Lichnoe()
        {
            InitializeComponent();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            
        }
        private void LoadGrid(string customSelect = null)
        {
            if (customSelect == null)
            {
                customSelect =
                  $@"SELECT        KtoOstavilZayvku AS
                                                                           Отправитель,Status AS [Статус рассмотрения], NaimenovaniyTovara AS
                                                                           
                                                                           [Наименование товара], Kolvo AS
                                                                           [Колличество товара], DataRazmejeniy AS [Дата размещение заявки]
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
                    if ((string)dr.ItemArray[1] == "Status")
                        dr["Status"] = "(Не рассмотрена) " + dr["Status"];
                }


                dataGridView1.DataSource = tb;
                dataGridView1.Columns[0].Visible = false;


            };
        }

            private void Lichnoe_Load(object sender, EventArgs e)
        {
            LoadGrid();
            checkBox_deleted.Visible = false;
           

        }
       

        private void btn_setting_Click(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            

           

        }

        private void dgv_moye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_moye_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
        public static bool IsFileInUse(string filename)
        {
            if (File.Exists(filename))
            {
                FileStream fileStream = null;
                try
                {
                    using (fileStream = File.Open(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    {

                    }
                    return false;
                }
                catch (IOException ex)
                {

                    return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            Mainform hd = new Mainform(); hd.Show(); this.Hide();
        }

        private void btn_myObyav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь на данной странице", "Внимение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_createObyav_Click(object sender, EventArgs e)
        {
            Main ds = new Main(); ds.Show(); this.Hide();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            HistoryForm aa = new HistoryForm(); aa.Show(); this.Hide();
        }

        private void btn_setting_Click_1(object sender, EventArgs e)
        {
            About a = new About(); a.Show(); this.Hide();
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

            worksheet.Cells[1, 1] = "Название";
            worksheet.Cells[1, 2] = "Изображение";
            worksheet.Cells[1, 3] = "Описание";
            worksheet.Cells[1, 4] = "Цена";
            worksheet.Cells[1, 5] = "Срок";

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    
}

