using Examen.Core;
using MetroFramework.Forms;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;

namespace Examen.Main
{
    public partial class autorization : MetroForm
    {
        
        public autorization()
        {
            InitializeComponent();
            btn_enter.Click += async (s, a) => await AutomatedLoginAsync();
            forgetLink.Click += (s, a) => forgetLink_LinkClicked_1();
            InitFormSettings();


        }
        private void InitFormSettings()
        {
            // Открываем форму в полноэкранном режиме
            this.WindowState = FormWindowState.Maximized;

            // Делаем все элементы авторасширяемыми
            this.AutoSize = true;
           

            // Настраиваем внешний вид формы
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void autorization_Load(object sender, EventArgs e)
        {
            tb_pass.UseSystemPasswordChar = true;
        }

        private void forgetLink_LinkClicked_1()
        {
            new Registration().Show(); this.Hide();
        }

        public async Task<Models.usersProgram> AuthenticateUserAsync(string login, string password)
        {
            using (var context = new Models.PP_KADNIKOV3Entities())
            {
                return await context.usersProgram.FirstOrDefaultAsync(u => u.loginI == login && u.PasI == password);
            }
        }

        public async Task AutomatedLoginAsync()
        {
            try
            {
                Models.usersProgram user = await AuthenticateUserAsync(tb_log.Text, tb_pass.Text);

                Core.Database.userImage = user?.ID_dol.ToString();

                if (user != null)
                {
                    ShowForm(user.acces);
                    Core.Database.userId = GetUserTypeId(user.acces);
                }
                else
                {
                    ShowErrorMessage("Неверный логин или пароль");
                    return;
                }

                using (var dbContext = new Models.PP_KADNIKOV3Entities())
                {
                    var newLog = CreateNewLog(tb_log.Text);
                    dbContext.Transactionprogram.Add(newLog);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ShowForm(string access)
        {
            switch (access)
            {
                case "Administration":
                    ShowFormbin();
                    break;
                case "User":
                    ShowFormbinUsers();
                    break;
                default:
                    ShowErrorMessage("Неверный логин или пароль");
                    break;
            }
        }

        private int GetUserTypeId(string access)
        {
            switch (access)
            {
                case "Administration":
                    return 1;
                case "User":
                    return 2;
                default:
                    return 0;
            }
        }

        private Models.Transactionprogram CreateNewLog(string username)
        {
            return new Models.Transactionprogram
            {
                NameLog = username,
                DateLog = DateTime.Now
            };
        }



        private void ShowFormbin()
        {
            new Formbin().Show();
            Hide();
        }

        private void ShowFormbinUsers()
        {
            new FormbinUsers().Show();
            Hide();
        }

        private void ShowErrorMessage(string message)
        {
            errLb.Visible = Enabled;
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        


    }
}
