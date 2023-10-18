using Examen.Core;
using Examen.Base;
using Examen.Models;
using Examen.View;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Examen.Presenter
{
    public class FormbinPresenter
    {
        private readonly IFormbinView view;

        public FormbinPresenter(IFormbinView view)
        {
            this.view = view;
            view.AllObyavClicked += OnAllObyavClicked;
            view.AvatarLoaded += OnAvatarLoaded;
            
        }

        public async Task LoadAvatarAsync()
        {
            try
            {
                IDatabaseService databaseService = new DatabaseService();
                IImageService imageService = new ImageService();

                int userID = int.Parse(Core.Database.userImage);
                usersProgram userProgram = await databaseService.GetUserProgramAsync(userID);

                if (userProgram != null)
                {
                    byte[] avatarBytes = userProgram.Avatar;
                    view.UserImage = avatarBytes;
                    view.UserName = userProgram.Ima.ToString();
                }
            }
            catch
            {
                MessageBox.Show("У пользователя не загружен аватар");
            }
        }
        private void OnCloseApplicationClicked(object sender, EventArgs e)
        {
            // Закрыть приложение
            view.CloseApplication();
        }
        private void CloseApplication()
        {
            Application.Exit();
        }

        private void OnAllObyavClicked(object sender, EventArgs e)
        {
            // Обработка нажатия кнопки "Все объявления"
            // Вызов метода на форме view для перехода к другой форме
            view.ToForm();
        }

        private void OnAvatarLoaded(object sender, EventArgs e)
        {
            // Загрузка аватара при запуске формы
            LoadAvatarAsync();
        }
    }
}
