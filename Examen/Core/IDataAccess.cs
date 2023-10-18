using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface IDataAccess
    {
        Task AddObrazovanie(Base.Obrazovanie obrazovanie);
        Task<Base.Obrazovanie> GetObrazovanieById(int obrazovanieId);
        Task UpdateObrazovanie(Base.Obrazovanie obrazovanie);
        Task DeleteObrazovanie(int obrazovanieId);
    }
}
