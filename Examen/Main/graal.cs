using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Examen.Main
{
    public partial class graal : MetroForm
    {
        public graal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void graal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Core.Database.Query(@"select *from categories");
        }

        private void printBtn_Click(object sender, EventArgs e)
        {





        }

        private void btn_allObyav_Click(object sender, EventArgs e)
        {
            new sfera().Show(); this.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new postavjiki().Show(); this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btn_allObyav_Click_1(object sender, EventArgs e)
        {
            new sfera().Show(); this.Hide();
        }

        private void btn_myObyav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь на данной странице", "Внимение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_setting_Click_1(object sender, EventArgs e)
        {
            new About().Show(); this.Hide();
        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Отчёт.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Не удается скопировать данные на диск" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Успешный экспорт данных в PDF", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при экспортирование" + ex.Message);
                        }
                    }
                }

            }


        }


    }
}

