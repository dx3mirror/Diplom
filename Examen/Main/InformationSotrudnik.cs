using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Threading;
using Aspose.Words;


namespace Examen.Main
{
    public partial class InformationSotrudnik : MetroForm
    {
        public InformationSotrudnik()
        {
            
            InitializeComponent();
            Thread myThread = new Thread(btnEnabled);
            myThread.Start();
             
         
            
            long totalMemory = GC.GetTotalMemory(false);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            btn_obrazovanie.Click += (s, a) => Obrazovanie();

            btn_add.Click += (s, a) => MethodAdd();
            btn_upd.Click += (s, a) => MethodUpdate();
            btn_del.Click += (s, a) => MethodDelete();
            btn_family.Click += (s, a) => Family();
            btn_otchet.Click += (s, a) => MethodPetchat();
            btn_Passport.Click += (s, a) => Passport();
            tb_prognul.Click += (s, a) => PrintFine();
            bt_dogovor.Click += (s, a) => PrintFine2();
            btn_doljnost.Click += (s, a) => Doljnost();
            bt_EXP.Click += (s, a) => Exp();
            btn_uvolen.Click += (s, a) => MethotUvolen();
            btn_war.Click += (s, a) => War();
            btn_pdf.Click += (s, a) => Preobrozovaniy();
            
            
            btn_dop.Click += (s, a) => Dop();
        }

        private void Preobrozovaniy()
        {
            Aspose.Words.Document doc = new Aspose.Words.Document("DispPrikaz-.docx");
            // Сохранить как PDF
            doc.Save("output.pdf");
        }

        

        private void SvedeniyaForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            btnEnabled();
           //btn_pdf.Visible = false;


        }

       private void btnEnabled()
        {
            if (Core.Database.userId == 0)
            {



                btn_obrazovanie.Enabled = false;
            }
            else
            {

                btn_obrazovanie.Enabled = true;

            }
        }

        async private void LoadGrid(string customSelect = null)
        {
            await System.Threading.Tasks.Task.Delay(3); 

            if (customSelect == null)
            {
                 customSelect =
                    $@"SELECT ID
                                                                     ,[lastname]           as Фамилия
                                                                     ,[nam]                as Имя
                                                                     ,[patronomic]         as Отчество
                                                                     ,[mesto_rojd]         as 'Место рождения'
                                                                     ,[telefon]            as Телефон
                                                                     ,[datarojdeniya]      as 'Дата рождения'
                                                                     ,[in_yaz]             as 'Иностранный язык'
                                                                     ,[grajdanstvo]        as Гражданство
                                                                     ,[Pol]                as Пол
                                                                     ,[Identitynomer]      as  'Идентификационный номер'
                                                                     ,[OKIN]               as 'Код по окин'
                                                                     ,[brak]               as Брак
                                                                     ,[del]                as Удаление
                                                                     
                                                                 FROM[dbo].[Sotrudnik] ";
               

                    if (checkBox_deleted.Checked)
                    customSelect += " where del = 'yes'";
                else
                {
                    customSelect += " where del = 'no'";
                }
            }
            System.Data.DataTable tb = Core.Database.Query1(customSelect);

            if (tb != null)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    if ((string)dr.ItemArray[13] == "del")
                        dr["del"] = "(no) " + dr["del"];
                }


                DGV_Sotrudniki.DataSource = tb;
                DGV_Sotrudniki.Columns[0].Visible = false;
                DGV_Sotrudniki.Columns[13].Visible = false;

            };

            


        }
        async private void MethodAdd()
        {
            await System.Threading.Tasks.Task.Delay(100);

            try
            {
                string sqlExpression = "AddSotrudnik";

                using (SqlConnection connection = new SqlConnection(Core.Database.con))
                {
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    command.CommandType = CommandType.StoredProcedure;
       
                    SqlParameter nameParam = new SqlParameter
                    {ParameterName = "@fam",Value = tb_fam.Text};
                    command.Parameters.Add(nameParam);

                    SqlParameter ageParam = new SqlParameter
                    {ParameterName = "@nam",Value = tb_name.Text};
                    command.Parameters.Add(ageParam);

                    SqlParameter OthParam = new SqlParameter
                    {ParameterName = "@oth", Value = tb_otch.Text};
                    command.Parameters.Add(OthParam);

                    SqlParameter telParam = new SqlParameter
                    {ParameterName = "@tel",Value = tb_tel.Text};
                    command.Parameters.Add(telParam);

                    SqlParameter datParam = new SqlParameter
                    {ParameterName = "@dat", Value = dateTP_birthday.Value.ToString()};
                    command.Parameters.Add(datParam);

                    SqlParameter englishParam = new SqlParameter
                    {ParameterName = "@english", Value = tb_Inostranniy.Text};
                    command.Parameters.Add(englishParam);

                    SqlParameter grajdanParam = new SqlParameter
                    {ParameterName = "@grajdan", Value = tb_Inostranniy.Text};
                    command.Parameters.Add(grajdanParam);

                    SqlParameter brakParam = new SqlParameter
                    {ParameterName = "@brak", Value = cb_brak.Text};
                    command.Parameters.Add(brakParam);

                    SqlParameter mRojd = new SqlParameter
                    {ParameterName = "@mRojd",Value = tb_mestorojd.Text};
                    command.Parameters.Add(mRojd);

                    SqlParameter mPol = new SqlParameter
                    {ParameterName = "@mPol", Value = tb_pol.Text};
                    command.Parameters.Add(mPol);

                    SqlParameter idennam = new SqlParameter
                    {ParameterName = "@idennam",
                        Value = tb_identyty.Text};
                    command.Parameters.Add(idennam);

                    SqlParameter mOKIN = new SqlParameter
                    {
                        ParameterName = "@mOKIN",
                        Value = tb_identyty.Text
                    };
                    command.Parameters.Add(mOKIN);


                    var id = await command.ExecuteScalarAsync();

                    LoadGrid();

                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


                

           
        }
        private void Passport()
        {
            new PassportSotrudnik().Show(); 
        }
        private void Obrazovanie()
        {
            new InformationObrozovaniySotrudnik().Show();
          
        }
        private void Dop()
        {
            new SotrudnikDopDokument().Show();
        }
        private void Doljnost()
        {
            new Doljnost().Show(); 
        }
        private void Exp()
        {
            new Staj().Show();
        }
        private void War()
        {
            new WarUchet().Show();
        }
        private void Family()
        { new InformationFamilySotrudnik().Show(); }
       async private void MethodUpdate()
        {
            await System.Threading.Tasks.Task.Delay(100);

            
                string sqlExpression = "UpdateSotrudnik";

                using (SqlConnection connection = new SqlConnection(Core.Database.con))
                {
                    await connection.OpenAsync();

                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID", DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString());

                SqlParameter nameParam = new SqlParameter
                    {
                        ParameterName = "@fam",
                        Value = tb_fam.Text
                    };

                    command.Parameters.Add(nameParam);

                    SqlParameter ageParam = new SqlParameter
                    {
                        ParameterName = "@nam",
                        Value = tb_name.Text
                    };
                    command.Parameters.Add(ageParam);

                    SqlParameter OthParam = new SqlParameter
                    {
                        ParameterName = "@oth",
                        Value = tb_otch.Text
                    };
                    command.Parameters.Add(OthParam);

                    SqlParameter telParam = new SqlParameter
                    {
                        ParameterName = "@tel",
                        Value = tb_tel.Text
                    };
                    command.Parameters.Add(telParam);

                    SqlParameter datParam = new SqlParameter
                    {
                        ParameterName = "@dat",
                        Value = dateTP_birthday.Value.ToString()
                    };
                    command.Parameters.Add(datParam);

                    SqlParameter englishParam = new SqlParameter
                    {
                        ParameterName = "@english",
                        Value = tb_Inostranniy.Text
                    };
                    command.Parameters.Add(englishParam);

                    SqlParameter grajdanParam = new SqlParameter
                    {
                        ParameterName = "@grajdan",
                        Value = tb_Inostranniy.Text
                    };
                    command.Parameters.Add(grajdanParam);

                    SqlParameter brakParam = new SqlParameter
                    {
                        ParameterName = "@brak",
                        Value = cb_brak.Text
                    };
                    command.Parameters.Add(brakParam);

                    SqlParameter mRojd = new SqlParameter
                    {
                        ParameterName = "@mRojd",
                        Value = tb_mestorojd.Text
                    };
                    command.Parameters.Add(mRojd);

                    SqlParameter mPol = new SqlParameter
                    {
                        ParameterName = "@mPol",
                        Value = tb_pol.Text
                    };
                    command.Parameters.Add(mPol);

                    SqlParameter idennam = new SqlParameter
                    {
                        ParameterName = "@idennam",
                        Value = tb_identyty.Text
                    };
                    command.Parameters.Add(idennam);

                    SqlParameter mOKIN = new SqlParameter
                    {
                        ParameterName = "@mOKIN",
                        Value = tb_identyty.Text
                    };
                    command.Parameters.Add(mOKIN);

                    


                    var id = await command.ExecuteScalarAsync();

                    LoadGrid();

                
            }
            
        }
        private void PrintFine()
        {
            Print.DiscpPrikaz(DGV_Sotrudniki);

            
        }
        private void PrintFine2()
        {
            Print.TrudPrikaz(DGV_Sotrudniki);
        }
        private void MethodDelete()
        {
            try
            {

                DGV_Sotrudniki.DataSource = Core.Database.Query1(@"UPDATE Sotrudnik   SET del = 'yes' WHERE ID = " + DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString());


                LoadGrid();

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void tb_exit_Click(object sender, EventArgs e)
        {
            new Formbin().Show(); this.Hide();
        }

        private void DGV_Sotrudniki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Core.Database.userId = (int)DGV_Sotrudniki.CurrentRow.Cells[0].Value;
                Core.Database.username = DGV_Sotrudniki.CurrentRow.Cells[1].Value.ToString() + " " + DGV_Sotrudniki.CurrentRow.Cells[2].Value.ToString() + " " + DGV_Sotrudniki.CurrentRow.Cells[3].Value.ToString();
                btnEnabled();
            }
            catch
            {
                MessageBox.Show("Выбрали пустое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_obrazovanie_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Sotrudniki_DoubleClick_1(object sender, EventArgs e)
        {
            tb_fam.Text = DGV_Sotrudniki.CurrentRow.Cells[1].Value.ToString();
            tb_name.Text = DGV_Sotrudniki.CurrentRow.Cells[2].Value.ToString();
            tb_otch.Text = DGV_Sotrudniki.CurrentRow.Cells[3].Value.ToString();
            tb_mestorojd.Text = DGV_Sotrudniki.CurrentRow.Cells[4].Value.ToString();
            tb_tel.Text = DGV_Sotrudniki.CurrentRow.Cells[5].Value.ToString();
            dateTP_birthday.Value = DateTime.Parse(DGV_Sotrudniki.CurrentRow.Cells[6].Value.ToString());
            tb_Inostranniy.Text = DGV_Sotrudniki.CurrentRow.Cells[7].Value.ToString();
            tb_grajdanstvo.Text = DGV_Sotrudniki.CurrentRow.Cells[8].Value.ToString();
            tb_pol.Text = DGV_Sotrudniki.CurrentRow.Cells[9].Value.ToString();
            tb_identyty.Text = DGV_Sotrudniki.CurrentRow.Cells[10].Value.ToString();
            tb_okin.Text = DGV_Sotrudniki.CurrentRow.Cells[11].Value.ToString();
            cb_brak.Text = DGV_Sotrudniki.CurrentRow.Cells[12].Value.ToString();
        }

        private void btn_otchet_Click_1(object sender, EventArgs e)
        {
            
        }
        private void MethodPetchat()
        {

            Print.Othet(DGV_Sotrudniki);
           
        }

        private void MethotUvolen()
        {
            Print.Uvolen(DGV_Sotrudniki);
        }

        private void checkBox_deleted_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void MethotPdf()
        {
            if (DGV_Sotrudniki.Rows.Count > 0)
            {
                BaseFont baseFont = BaseFont.CreateFont("C:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "file_name.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)

                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(DGV_Sotrudniki.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in DGV_Sotrudniki.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                               
                                

                            }

                            foreach (DataGridViewRow row in DGV_Sotrudniki.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(new Phrase(cell?.Value?.ToString() ?? "Null", font));




                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Данные успешно сохранены.", "");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

      

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
    

