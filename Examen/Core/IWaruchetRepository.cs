using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface IWaruchetRepository
    {
        Task<List<Models.Waruchet>> GetWaruchetByUserId(int userId);
        Task AddWaruchet(Models.Waruchet waruchet);
        Task UpdateWaruchet(Models.Waruchet waruchet);
        Task DeleteWaruchet(int id);
    }
}
