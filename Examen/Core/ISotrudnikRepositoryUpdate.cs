using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface ISotrudnikRepositoryUpdate
    {
        Task<Sotrudnik> GetById(int id);
        Task Update(Sotrudnik sotrudnik);
    }
}
