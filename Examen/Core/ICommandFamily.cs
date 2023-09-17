using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface ICommandFamily
    {
        Task ExecuteAsync();
    }
}
