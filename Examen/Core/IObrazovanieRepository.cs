using Examen.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface IObrazovanieRepository : IRepositorySotrudnikObrozovaniy<Obrazovanie>
    {
        List<ObrazovanieDto> GetByUserId(int userId);
    }
}
