using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface IDatabaseService
    {
        Task<Models.usersProgram> GetUserProgramAsync(int userId);
    }
}
