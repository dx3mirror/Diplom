using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public abstract class BaseRegistrationChecker : IRegistrationChecker
    {
        private IRegistrationChecker _nextChecker;

        public IRegistrationChecker SetNext(IRegistrationChecker nextChecker)
        {
            _nextChecker = nextChecker;
            return nextChecker;
        }

        public virtual bool CheckCondition()
        {
            return _nextChecker?.CheckCondition() ?? true;
        }
    }
}
