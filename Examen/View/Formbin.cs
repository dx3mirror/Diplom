using Examen.Presenter;
using Examen.View;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Main
{
    public partial class Formbin : Form, IFormbinView
    {
        private FormbinPresenter presenter;

        public event EventHandler AllObyavClicked
        {
            add { btn_allObyav.Click += value; }
            remove { btn_allObyav.Click -= value; }
        }

        public event EventHandler AvatarLoaded
        {
            add { Load += value; }
            remove { Load -= value; }
        }

        public byte[] UserImage
        {
            set
            {
                Image avatar = ImageFromBytes(value);
                pictureBox4.Image = avatar;
            }
        }

        public string UserName
        {
            set { label5.Text = value; }
        }

        public Formbin()
        {
            InitializeComponent();
            presenter = new FormbinPresenter(this);

            // Добавьте обработчик события Click для bunifuPictureBox3
            bunifuPictureBox3.Click += OnPictureBox3Click;
        }

        public void ToForm()
        {
            InformationSotrudnik information = new InformationSotrudnik();
            information.Show();
            this.Hide();
        }

        public void CloseApplication()
        {
            Application.Exit();
        }

        // Метод для преобразования массива байтов в изображение
        private Image ImageFromBytes(byte[] imageBytes)
        {
            using (var ms = new System.IO.MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void OnPictureBox3Click(object sender, EventArgs e)
        {
            CloseApplication(); // Вызов метода для закрытия приложения
        }
    }

}
