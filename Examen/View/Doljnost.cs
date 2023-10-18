using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Base;

namespace Examen.Main
{
    public partial class Doljnost : Form
    {
        private PP_KADNIKOV3Entities context;

        public Doljnost()
        {
            InitializeComponent();
            btn_save.Click += (s, a) => SaveMethod();
            context = new PP_KADNIKOV3Entities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

            private async void FormLoad()
            {
                var doljnost = await GetDoljnostForCurrentUser();
            
                groupBox1.Text = Core.Database.username;
            
                if (doljnost == null)
                {
                    ShowMessage("Новая запись у сотрудника", MessageBoxIcon.Warning);
                }
                else
                {
                    UpdateUIFromDoljnost(doljnost);
                }
            }

            private async void SaveMethod()
            {
                var doljnost = await GetDoljnostForCurrentUser();
            
                if (doljnost == null)
                {
                    CreateNewDoljnost();
                }
                else
                {
                    UpdateDoljnost();
                }
            }
            
            private async Task<doljnost> GetDoljnostForCurrentUser()
            {
                return await context.doljnost
                    .Where(d => d.fk_kod_sotrudnik == Core.Database.userId)
                    .FirstOrDefaultAsync();
            }
            
            private void ShowMessage(string message, MessageBoxIcon icon)
            {
                MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, icon);
            }
            
            private void UpdateUIFromDoljnost(doljnost doljnost)
            {
                MasTb_pas.Text = doljnost.naimenoviy_doljnosti;
                dtp_datavidachi.Value = DateTime.Parse(doljnost.s_kogo);
                dtp_dataregistracii.Value = DateTime.Parse(doljnost.po_kokoe);
                tb_vidacha.Text = doljnost.kol_vo?.ToString() ?? string.Empty;
                tb_adress.Text = doljnost.otvetstveniy;
            }
            
            private void CreateNewDoljnost()
            {
                var newDoljnost = CreateDoljnostFromInput();
            
                context.doljnost.Add(newDoljnost);
                context.SaveChanges();
            
                ShowMessage("Запись успешно добавлена", MessageBoxIcon.Information);
            }
            
            private doljnost CreateDoljnostFromInput()
            {
                var newDoljnost = new doljnost
                {
                    fk_kod_sotrudnik = Core.Database.userId,
                    naimenoviy_doljnosti = MasTb_pas.Text,
                    s_kogo = dtp_datavidachi.Value.ToString("yyyy-MM-dd"),
                    po_kokoe = dtp_dataregistracii.Value.ToString("yyyy-MM-dd"),
                };
            
                if (int.TryParse(tb_vidacha.Text, out int kol_vo))
                {
                    newDoljnost.kol_vo = kol_vo;
                }
            
                newDoljnost.otvetstveniy = tb_adress.Text;
            
                return newDoljnost;
            }
            
            private void UpdateDoljnost()
            {
                var existingDoljnost = GetDoljnostForCurrentUser().Result;
                UpdateDoljnostFromInput(existingDoljnost);
                context.SaveChanges();
            
                ShowMessage("Запись успешно изменена", MessageBoxIcon.Information);
            }
            
            private void UpdateDoljnostFromInput(doljnost doljnost)
            {
                doljnost.naimenoviy_doljnosti = MasTb_pas.Text;
                doljnost.s_kogo = dtp_datavidachi.Value.ToString("yyyy-MM-dd");
                doljnost.po_kokoe = dtp_dataregistracii.Value.ToString("yyyy-MM-dd");
            
                if (int.TryParse(tb_vidacha.Text, out int kol_vo))
                {
                    doljnost.kol_vo = kol_vo;
                }
                else
                {
                    doljnost.kol_vo = null;
                }
            
                doljnost.otvetstveniy = tb_adress.Text;
            }
            
            
                    private void btn_save_Click(object sender, EventArgs e)
                    {
                        // Ваш обработчик для кнопки сохранения
                    }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
