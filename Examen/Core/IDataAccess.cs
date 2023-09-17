using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface IDataAccess
    {
        Task AddObrazovanie(Models.Obrazovanie obrazovanie);
        Task<Models.Obrazovanie> GetObrazovanieById(int obrazovanieId);
        Task UpdateObrazovanie(Models.Obrazovanie obrazovanie);
        Task DeleteObrazovanie(int obrazovanieId);
    }
}
