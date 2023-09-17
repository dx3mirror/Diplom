using Examen.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Aspose.Words;
using SautinSoft;


namespace Examen
{
    class Print
    {
        private Print()
        {

        }

        public static void Othet(DataGridView DGV_Sotrudniki)
        {
            string tempPath = System.IO.Path.GetTempFileName();
            System.IO.File.WriteAllBytes(tempPath, Properties.Resources.T2_Form);
            Excel.Application excelApplication = new Excel.Application();
            Excel._Workbook excelWorkbook;
            excelWorkbook = excelApplication.Workbooks.Open(tempPath);
            Excel.Worksheet worksheet = excelWorkbook.Sheets[1];
            Excel.Range r1 = worksheet.Range[worksheet.Cells[24, 2], worksheet.Cells[26, 2]];
            worksheet.Name = "Личная карточка сотрудника";
            string sqlText = $@"SELECT                      
                                                            [ID],
                                                            [lastname],
                                                            [nam],
                                                            [patronomic],
                                                            [telefon],
                                                            [mesto_rojd],
                                                            [Pol],
                                                            [Identitynomer],
                                                            [OKIN],
                                                            [nazvanieuchrejdeniya],
                                                            [kvalifikachiyapoObrazovaniyu],
                                                            [nazvanieuchrejdeniya2],
                                                            [kvalifikachiyapoObrazovaniyu2],
                                                            [poslevuzovoe],
                                                            [adress],
                                                            [datarojdeniya], 
                                                            [in_yaz],
                                                            [grajdanstvo],
                                                            [brak],
                                                            [naimenoviy_doljnosti],
                                                            [obrazovanie]
                                                            FROM     Sotrudnik , doljnost,
                  Obrazovanie  where Sotrudnik.ID = Obrazovanie.fk_kod_sotrudnika AND Sotrudnik.ID = doljnost.fk_kod_sotrudnik AND Sotrudnik.ID = @currValue";
            SqlConnection conn = new SqlConnection(Core.Database.con);
            using (SqlCommand cmd = new SqlCommand(sqlText, conn))
            {
                cmd.Parameters.AddWithValue("@currValue", DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString());
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        worksheet.Cells[18, 2] = dr["lastname"];
                        worksheet.Cells[8, 3] = dr["Identitynomer"];
                        worksheet.Cells[18, 5] = dr["nam"];
                        worksheet.Cells[18, 8] = dr["patronomic"];
                        worksheet.Cells[15, 9] = dr["telefon"];
                        worksheet.Cells[21, 3] = dr["datarojdeniya"];
                        worksheet.Cells[25, 4] = dr["in_yaz"];
                        worksheet.Cells[24, 3] = dr["grajdanstvo"];
                        worksheet.Cells[8, 5] = dr["brak"];
                        worksheet.Cells[29, 3] = dr["obrazovanie"];
                        worksheet.Cells[56, 3] = dr["naimenoviy_doljnosti"];
                        worksheet.Cells[23, 3] = dr["mesto_rojd"];
                        worksheet.Cells[8, 10] = dr["OKIN"];
                        worksheet.Cells[24, 9] = dr["OKIN"];
                        worksheet.Cells[25, 9] = dr["OKIN"];
                        worksheet.Cells[27, 9] = dr["OKIN"];
                        worksheet.Cells[29, 9] = dr["OKIN"];
                        worksheet.Cells[46, 9] = dr["OKIN"];
                        worksheet.Cells[33, 1] = dr["nazvanieuchrejdeniya"];
                        worksheet.Cells[36, 1] = dr["kvalifikachiyapoObrazovaniyu"];
                        worksheet.Cells[40, 1] = dr["nazvanieuchrejdeniya2"];
                        worksheet.Cells[43, 1] = dr["kvalifikachiyapoObrazovaniyu2"];
                        worksheet.Cells[46, 5] = dr["poslevuzovoe"];
                    }
                }
            }
            excelApplication.Visible = true;
            excelApplication.UserControl = true;
            r1.WrapText = true;
        }
        public static void Uvolen(DataGridView DGV_Sotrudniki)
        {
            string tempPath = System.IO.Path.GetTempFileName();

            System.IO.File.WriteAllBytes(tempPath, Properties.Resources.t_8_prikaz_ob_uvolnenii);

            Excel.Application excelApplication = new Excel.Application();
            Excel._Workbook excelWorkbook;
            excelWorkbook = excelApplication.Workbooks.Open(tempPath);

            Excel.Worksheet worksheet = excelWorkbook.Sheets[1];

            Excel.Range r1 = worksheet.Range[worksheet.Cells[24, 2], worksheet.Cells[26, 2]];

            worksheet.Name = "Увольнения сотрудника";

            string sqlText = $@"SELECT ID
                                                                     ,[lastname]           
                                                                     ,[nam] 
                                                                     ,[naimenoviy_doljnosti]
                                                                     ,[patronomic]         
                                                                     ,[del] 
                                                                 FROM[dbo].[Sotrudnik], doljnost  where  Sotrudnik.ID = doljnost.fk_kod_sotrudnik AND Sotrudnik.ID = @currValue";







            SqlConnection conn = new SqlConnection(Core.Database.con);
            using (SqlCommand cmd = new SqlCommand(sqlText, conn))
            {

                cmd.Parameters.AddWithValue("@currValue", DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString());
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        worksheet.Cells[15, 5] = dr["lastname"];
                        worksheet.Cells[15, 16] = dr["nam"];
                        worksheet.Cells[15, 34] = dr["lastname"];
                        worksheet.Cells[21, 1] = dr["naimenoviy_doljnosti"];



                    }
                }
            }

            excelApplication.Visible = true;
            excelApplication.UserControl = true;
            r1.WrapText = true;
        }

        
            public static void DiscpPrikaz(DataGridView DGV_Sotrudniki)
            {

                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
                object fileName = System.Windows.Forms.Application.StartupPath + "\\DispPrikaz-.docx";
                Microsoft.Office.Interop.Word.Document document = application.Documents.Add(ref fileName);
                var doc = new Document(System.Windows.Forms.Application.StartupPath + "\\DispPrikaz-.docx");
                document.Variables["ID"].Value = DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString();
                document.Variables["UserName"].Value = DGV_Sotrudniki.CurrentRow.Cells[1].Value.ToString() + " " +
                    DGV_Sotrudniki.CurrentRow.Cells[2].Value.ToString() + " " +
                    DGV_Sotrudniki.CurrentRow.Cells[3].Value.ToString();
                document.Variables["Doljnost"].Value = DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString();

                document.Variables["DockStyle"].Value = DGV_Sotrudniki.CurrentRow.Cells[1].Value.ToString() + " " +
                DGV_Sotrudniki.CurrentRow.Cells[2].Value.ToString() + " " +
                DGV_Sotrudniki.CurrentRow.Cells[3].Value.ToString();
                document.Fields.Update();
                application.Visible = true;
                doc.Save(System.Windows.Forms.Application.StartupPath + "\\DispPrikaz-.pdf");

            }
        


        public static void TrudPrikaz (DataGridView DGV_Sotrudniki)
        {
            Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
            object fileName = System.Windows.Forms.Application.StartupPath + "\\TrudDog.docx";
            Microsoft.Office.Interop.Word.Document document = application.Documents.Add(ref fileName);

            document.Variables["ID"].Value = DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString();
            document.Variables["UserName"].Value = DGV_Sotrudniki.CurrentRow.Cells[1].Value.ToString() + " " +
                DGV_Sotrudniki.CurrentRow.Cells[2].Value.ToString() + " " +
                DGV_Sotrudniki.CurrentRow.Cells[3].Value.ToString();
            document.Variables["Doljnost"].Value = DGV_Sotrudniki.CurrentRow.Cells[0].Value.ToString();
            document.Fields.Update();
            application.Visible = true;
        }

        public static void Zayvka (DataGridView dataGridView1)
        {
            string tempPath = System.IO.Path.GetTempFileName();

            System.IO.File.WriteAllBytes(tempPath, Properties.Resources.schet_dogovor_postavki_tovara);

            Excel.Application excelApplication = new Excel.Application();
            Excel._Workbook excelWorkbook;
            excelWorkbook = excelApplication.Workbooks.Open(tempPath);

            Excel.Worksheet worksheet = excelWorkbook.Sheets[1];

            Excel.Range r1 = worksheet.Range[worksheet.Cells[24, 2], worksheet.Cells[26, 2]];

            worksheet.Name = "Личная карточка сотрудника";



            string sqlText = $@"SELECT        [ID],
                                              [KtoOstavilZayvku],
                                              [NaimenovaniyTovara],
                                              [Kolvo],
                                              [Cena],
                                              [Summa],
                                              [INN],
                                              [KPP],
                                              [Poluhatel],
                                              [Bank],
                                              [Adress],
                                              [NomerCheta],
                                              [Buhalter],
                                              [Rukovoditelpredpriytiy],
                                              [DataRazmejeniy]
FROM            Postavki  where ID = @currValue";



            SqlConnection conn = new SqlConnection(Core.Database.con);
            using (SqlCommand cmd = new SqlCommand(sqlText, conn))
            {
                cmd.Parameters.AddWithValue("@currValue", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                conn.Open();


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        worksheet.Cells[2, 3] = dr["INN"];
                        worksheet.Cells[2, 4] = dr["KPP"];
                        worksheet.Cells[4, 2] = dr["Poluhatel"];
                        worksheet.Cells[6, 2] = dr["Bank"];
                        worksheet.Cells[6, 7] = dr["NomerCheta"];
                        worksheet.Cells[8, 4] = dr["Adress"];
                        worksheet.Cells[16, 3] = dr["NaimenovaniyTovara"];
                        worksheet.Cells[16, 6] = dr["Kolvo"];
                        worksheet.Cells[16, 7] = dr["Cena"];
                        worksheet.Cells[16, 8] = dr["Summa"];
                        worksheet.Cells[37, 5] = dr["Rukovoditelpredpriytiy"];
                        worksheet.Cells[39, 5] = dr["Buhalter"];

                    }
                }
            }

            excelApplication.Visible = true;
            excelApplication.UserControl = true;
            r1.WrapText = true;
        }
    }
    
}
