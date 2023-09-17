using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Core
{
    public class RegistrationService
    {
        private readonly string _login;
        private readonly string _password;
        private readonly string _confirmPassword;
        private readonly string _ima;
        private readonly string _fam;
        private readonly string _oth;
        private readonly string _email;

        private readonly IRegistrationChecker _checkerChain;

        public RegistrationService(string login, string password, string confirmPassword, string ima,string fam, string oth, string email)
        {
            _login = login;
            _password = password;
            _confirmPassword = confirmPassword;
            _ima = ima;
            _fam = fam;
            _oth = oth;
            _email = email;

            _checkerChain = new PasswordLengthChecker(_password)
               .SetNext(new PasswordMatchChecker(_password, _confirmPassword));
        }

        public void RegistrationMethod()
        {
            if (_checkerChain.CheckCondition())
            {
                try
                {
                    using (var context = new Models.PP_KADNIKOV3Entities())
                    {
                        var user = new Models.usersProgram()
                        {
                            loginI = _login,
                            PasI = _password,
                            Avatar = Core.Database.image_bytes,
                            Family = _fam,
                            Email = _email,
                            Ima = _ima,
                            Oth = _oth
                        };

                        context.usersProgram.Add(user);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Ваша заявка предоставлена на рассмотрение", "Внимание", MessageBoxButtons.OK);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Ваш пароль недостаточно сложный", "Внимание", MessageBoxButtons.OK);
            }
        }
    }
}
