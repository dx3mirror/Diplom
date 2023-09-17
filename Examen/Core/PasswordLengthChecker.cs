using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class PasswordLengthChecker : BaseRegistrationChecker
    {
        private readonly string _password;

        public PasswordLengthChecker(string password)
        {
            _password = password;
        }

        public override bool CheckCondition()
        {
            if (_password.Length < 8 || _password.Length > 12)
            {
                return false;
            }

            return base.CheckCondition();
        }
    }

}
