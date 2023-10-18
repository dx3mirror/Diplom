using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Examen.View
{
    public interface IFormbinView
    {
        event EventHandler AllObyavClicked;
        event EventHandler AvatarLoaded;

        byte[] UserImage { set; }
        string UserName { set; }

        void ToForm();
        void Show();
        void Hide();
        void CloseApplication(); 
    }
}
