using Examen.Main;
using Examen.Models;
using Examen.View;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Presenter
{
    public class AuthorizationPresenter
    {
        private readonly IAuthorizationView view;
        private readonly AuthorizationModel model;

        public AuthorizationPresenter(IAuthorizationView view, AuthorizationModel model)
        {
            this.view = view;
            this.model = model;

            view.EnterClicked += async (s, a) => await AutomatedLoginAsync();
            view.ForgetLinkClicked += (s, a) => ShowRegistrationForm();

            // Подписка на событие PictureBox3Click
            view.PictureBox3Click += (s, a) => HandlePictureBox3Click();
        }

        private async Task AutomatedLoginAsync()
        {
            view.ShowProgressBar();

            try
            {
                Base.usersProgram user = await model.AuthenticateUserAsync(view.Login, view.Password);
                view.HideProgressBar();

                if (user != null)
                {
                    Core.Database.userImage = user?.ID_dol.ToString();
                    ShowForm(user.acces);
                    Core.Database.userId = GetUserTypeId(user.acces);

                    using (var dbContext = new Base.PP_KADNIKOV3Entities())
                    {
                        var newLog = CreateNewLog(view.Login);
                        dbContext.Transactionprogram.Add(newLog);
                        await dbContext.SaveChangesAsync();
                    }
                }
                else
                {
                    view.ShowErrorMessage("Неверный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                view.ShowErrorMessage(ex.Message);
            }
        }

        public void ShowForm(string access)
        {
            if (access == "Administration")
            {
                view.OpenForm(typeof(Formbin));
            }
            else
            {
                
                
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
        public void HandlePictureBox3Click()
        {
            // Закрыть приложение
            Application.Exit();
        }

        private Base.Transactionprogram CreateNewLog(string username)
        {
            return new Base.Transactionprogram
            {
                NameLog = username,
                DateLog = DateTime.Now
            };
        }

        private void ShowRegistrationForm()
        {
            Registration registrationForm = new Registration();
            registrationForm.Show();
        }
    }
}
