using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Examen.Main
{
    public partial class PassportSotrudnik : Form
    {
        public PassportSotrudnik()
        {
            InitializeComponent();
            btn_save.Click += (s, a) => SaveMethod();
        }

        private void PassportForm_Load(object sender, EventArgs e)
        {

           _ = LoadFormData();

        }

        async private Task LoadFormData()
        {
            var services = new ServiceCollection();
            services.AddTransient<IRepository<Base.Passport>, PassportRepository>();
            services.AddSingleton<Base.PP_KADNIKOV3Entities>();

            using (var serviceProvider = services.BuildServiceProvider()) // Создаем DI-контейнер
            {
                var userRepository = serviceProvider.GetRequiredService<IRepository<Base.Passport>>(); // Получаем экземпляр PassportRepository

                var userId = Core.Database.userId;
                var username = Core.Database.username;

                var passport = await userRepository.GetFirstOrDefaultAsync(p => p.FK_Sotrudnik == userId);
                groupBox1.Text = username;

                if (passport == null)
                {
                    MessageBox.Show("Новая запись у сотрудника", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MasTb_pas.Text = passport?.nomer_pasporta;
                    dtp_datavidachi.Value = (DateTime)(passport?.datavidachi ?? DateTime.MinValue);
                    dtp_dataregistracii.Value = (DateTime)(passport?.dataregistrachii_po_mestu ?? DateTime.MinValue);
                    tb_vidacha.Text = passport?.vidan;
                    tb_adress.Text = passport?.adressjitelstva_popasportu;
                    tb_adressFackt.Text = passport?.aress_fakticheskiy;
                }
            }
        }

        async private void SaveMethod()
        {
            var userId = Core.Database.userId;
            var passportRepository = PassportRepository.Instance;
            var passport = await passportRepository.GetPassportByUserId(userId);

            if (passport == null)
            {
                await passportRepository.AddPassport(userId, MasTb_pas.Text,
                    dtp_datavidachi.Value,
                    dtp_dataregistracii.Value,
                    tb_vidacha.Text, tb_adress.Text,
                    tb_adressFackt.Text);

                MessageBox.Show("Запись успешно добавлена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                await passportRepository.UpdatePassport(passport, MasTb_pas.Text,
                    dtp_datavidachi.Value,
                    dtp_dataregistracii.Value,
                    tb_vidacha.Text,
                    tb_adress.Text,
                    tb_adressFackt.Text);

                MessageBox.Show("Запись успешно изменена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MasTb_pas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
