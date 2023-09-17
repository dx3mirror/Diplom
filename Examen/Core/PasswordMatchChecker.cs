using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class PasswordMatchChecker : BaseRegistrationChecker
    {
        private readonly string _password;
        private readonly string _confirmPassword;

        public PasswordMatchChecker(string password, string confirmPassword)
        {
            _password = password;
            _confirmPassword = confirmPassword;
        }

        public override bool CheckCondition()
        {
            if (_password != _confirmPassword)
            {
                return false;
            }

            return base.CheckCondition();
        }
    }
}
