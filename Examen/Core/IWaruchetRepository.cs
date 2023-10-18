using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface IWaruchetRepository
    {
        Task<List<Base.Waruchet>> GetWaruchetByUserId(int userId);
        Task AddWaruchet(Base.Waruchet waruchet);
        Task UpdateWaruchet(Base.Waruchet waruchet);
        Task DeleteWaruchet(int id);
    }
}
