using System;
using System.Windows.Forms;
using System.Threading;
using Examen.Base;
using Examen.Core;


namespace Examen.Main
{
    public partial class InformationSotrudnik : Form
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
            btn_dop.Click += (s, a) => Dop();
            DGV_Sotrudniki.CellClick += DGV_Sotrudniki_CellClick;
            DGV_Sotrudniki.DoubleClick += DGV_Sotrudniki_DoubleClick_1;
            tb_exit.Click += tb_exit_Click;
            checkBox_deleted.CheckedChanged += checkBox_deleted_CheckedChanged;
            bunifuTextBox1.TextChange += (s, a) => PerformSearch();

        }
        private void SvedeniyaForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            btnEnabled();
            

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
        private void PerformSearch()
        {
            string searchKeyword = bunifuTextBox1.Text.Trim().ToLower(); // Получите ключевое слово для поиска, уберите лишние пробелы и приведите его к нижнему регистру (для регистронезависимого поиска)

            foreach (DataGridViewRow row in DGV_Sotrudniki.Rows)
            {
                // Проверяем, что строка не является новой строкой
                if (!row.IsNewRow)
                {
                    bool rowContainsKeyword = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            string cellValue = cell.Value.ToString().ToLower();
                            if (cellValue.Contains(searchKeyword))
                            {
                                rowContainsKeyword = true;
                                break; // Если найдено совпадение в текущей ячейке, можно завершить поиск в этой строке
                            }
                        }
                    }

                    row.Visible = rowContainsKeyword; // Скрываем или показываем строку в зависимости от наличия совпадений
                }
            }
        }



        async private void LoadGrid(string customSelect = null)
        {
            var dbContext = new PP_KADNIKOV3Entities();
            var sotrudnikRepository = new SotrudnikRepository(dbContext);
            var sotrudnikBuilder = new SotrudnikBuilder();
            var gridLoader = new GridLoader(sotrudnikRepository, sotrudnikBuilder);
            await gridLoader.LoadGrid(DGV_Sotrudniki, checkBox_deleted,customSelect);
            
        }

        async private void MethodAdd()
        {
            try
            {
                using (var unitOfWork = new UnitOfWorkAddSotrudnik())
                {
                    var sotrudnik = new Base.Sotrudnik
                    {
                        lastname = tb_fam.Text,
                        nam = tb_name.Text,
                        patronomic = tb_otch.Text,
                        telefon = tb_tel.Text,
                        datarojdeniya = dateTP_birthday.Value,
                        in_yaz = tb_tel.Text,
                        grajdanstvo = tb_grajdanstvo.Text,
                        brak = cb_brak.Text,
                        mesto_rojd = tb_mestorojd.Text,
                        Pol = tb_pol.Text,
                        Identitynomer = tb_identyty.Text,
                        OKIN = tb_okin.Text,
                        del = "no"
                    };

                    unitOfWork.SotrudnikRepository.Add(sotrudnik);
                    await unitOfWork.SaveChangesAsync();
                    LoadGrid();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Family()
        { new InformationFamilySotrudnik().Show(); }
        async private void MethodUpdate()
        {
            try
            {
                using (var unitOfWork = new UnitOfWorkUpdate())
                {
                    var sotrudnikRepository = unitOfWork.SotrudnikRepositoryUpdate;
                    var sotrudnik = await sotrudnikRepository.GetById(Core.Database.userId);

                    if (sotrudnik != null)
                    {
                        sotrudnik.lastname = tb_fam.Text;
                        sotrudnik.nam = tb_name.Text;
                        sotrudnik.patronomic = tb_otch.Text;
                        sotrudnik.telefon = tb_tel.Text;
                        sotrudnik.datarojdeniya = dateTP_birthday.Value;
                        sotrudnik.in_yaz = tb_tel.Text;
                        sotrudnik.grajdanstvo = tb_grajdanstvo.Text;
                        sotrudnik.brak = cb_brak.Text;
                        sotrudnik.mesto_rojd = tb_mestorojd.Text;
                        sotrudnik.Pol = tb_pol.Text;
                        sotrudnik.Identitynomer = tb_identyty.Text;
                        sotrudnik.OKIN = tb_okin.Text;
                        await sotrudnikRepository.Update(sotrudnik);
                        await unitOfWork.SaveChangesAsync();
                    }
                }
                LoadGrid();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность вводимых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private async void MethodDelete()
        {
            try
            {
                using (var unitOfWorkDelete = new UnitOfWorkDelete())
                {
                    var sotrudnik = await unitOfWorkDelete.Context.Sotrudnik.FindAsync(Core.Database.userId);

                    if (sotrudnik != null)
                    {
                        sotrudnik.del = "yes";

                        await unitOfWorkDelete.SaveChangesAsync();
                        unitOfWorkDelete.Commit();
                    }
                }

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
        public static class DataGridViewHelper
        {
            public static bool TryGetSelectedUserId(DataGridView dataGridView, out int userId)
            {
                userId = 0;

                if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells[0].Value != null)
                {
                    return int.TryParse(dataGridView.CurrentRow.Cells[0].Value.ToString(), out userId);
                }

                return false;
            }

            public static string GetUsername(DataGridView dataGridView)
            {
                if (dataGridView.CurrentRow != null)
                {
                    return dataGridView.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView.CurrentRow.Cells[2].Value.ToString() + " " + dataGridView.CurrentRow.Cells[3].Value.ToString();
                }

                return string.Empty;
            }
        }
        private void DGV_Sotrudniki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick();
        }

        private void HandleCellClick()
        {
            try
            {
                int userId;
                if (DataGridViewHelper.TryGetSelectedUserId(DGV_Sotrudniki, out userId))
                {
                    Core.Database.userId = userId;
                    Core.Database.username = DataGridViewHelper.GetUsername(DGV_Sotrudniki);
                    btnEnabled();
                }
                else
                {
                    return; // It might be worth considering some error handling, e.g. log the error.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выбрали пустое значение", "Ошибка" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally, you can log the exception details.
            }
        }

            private void btn_obrazovanie_Click(object sender, EventArgs e)
            {

            }

        private void DGV_Sotrudniki_DoubleClick_1(object sender, EventArgs e)
        {
            tb_fam.Text = GetCellValue(1);
            tb_name.Text = GetCellValue(2);
            tb_otch.Text = GetCellValue(3);
            tb_mestorojd.Text = GetCellValue(4);
            tb_tel.Text = GetCellValue(5);
            tb_tel.Text = GetCellValue(7);
            tb_grajdanstvo.Text = GetCellValue(8);
            tb_pol.Text = GetCellValue(9);
            tb_identyty.Text = GetCellValue(10);
            tb_okin.Text = GetCellValue(11);
            cb_brak.Text = GetCellValue(12);
        }
        private string GetCellValue(int columnNumber)
        {
            return DGV_Sotrudniki.CurrentRow.Cells[columnNumber].Value.ToString();
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


        private void ShowForm(Form form)
        {
            form.Show();
        }

        private void Passport()
        {
            ShowForm(new PassportSotrudnik());
        }

        private void Obrazovanie()
        {
            ShowForm(new InformationObrozovaniySotrudnik());
        }

        private void Dop()
        {
            ShowForm(new SotrudnikDopDokument());
        }

        private void Doljnost()
        {
            ShowForm(new Doljnost());
        }

        private void Exp()
        {
            ShowForm(new Staj());
        }

        private void War()
        {
            ShowForm(new WarUchet());
        }


        private void btn_pdf_Click(object sender, EventArgs e)
        {
            
        }

        
        
    }
    
}
    

