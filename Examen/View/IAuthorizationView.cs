using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.View
{
    public interface IAuthorizationView
    {
        string Login { get; set; }
        string Password { get; set; }
        void ShowProgressBar();
        void HideProgressBar();
        void ShowErrorMessage(string message);
        event EventHandler PictureBox3Click;
        void OpenForm(Type formType);  // Добавляем метод OpenForm
        event EventHandler EnterClicked;
        event EventHandler ForgetLinkClicked;
    }
}
