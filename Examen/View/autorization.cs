using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;


namespace Examen.Main
{
    public partial class autorization : Form , View.IAuthorizationView
    {
        private Presenter.AuthorizationPresenter presenter;
        public event EventHandler PictureBox3Click;
        public string Login
        {
            get { return tb_log.Text; }
            set { tb_log.Text = value; }
        }

        public string Password
        {
            get { return tb_pass.Text; }
            set { tb_pass.Text = value; }
        }

        public event EventHandler EnterClicked
        {
            add { btn_enter.Click += value; }
            remove { btn_enter.Click -= value; }
        }


        public event EventHandler ForgetLinkClicked
        {
            add { forgetLink.Click += value; }
            remove { forgetLink.Click -= value; }
        }

        public void ShowProgressBar()
        {
            // Реализация отображения индикатора выполнения
            bunifuProgressBar1.Visible = true;
        }
        public autorization()
        {
            InitializeComponent(); // Инициализация компонентов

            // После вызова InitializeComponent(), вы можете продолжить с остальной инициализацией, если она необходима.

            tb_pass.UseSystemPasswordChar = true;
            bunifuPictureBox3.Click += (s,a) => PictureBox3Click?.Invoke(this, EventArgs.Empty);

            // Создание модели и презентера
            Models.AuthorizationModel model = new Models.AuthorizationModel();
            presenter = new Presenter.AuthorizationPresenter(this, model);
        }

        public void HideProgressBar()
        {
            // Реализация скрытия индикатора выполнения
            bunifuProgressBar1.Visible = false;
        }

        public void ShowErrorMessage(string message)
        {
            // Реализация отображения сообщения об ошибке
            errLb.Visible = true;
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public void OpenForm(Type formType)
        {
            if (formType == typeof(Formbin))
            {
                ShowFormbin();
            }
            else if (formType == typeof(FormbinUsers))
            {
                ShowFormbinUsers();
            }
            else
            {
                ShowErrorMessage("Неверный логин или пароль");
            }
        }

    }
}
