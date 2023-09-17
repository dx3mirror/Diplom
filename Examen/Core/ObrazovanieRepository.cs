using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class ObrazovanieRepository : RepositorySotrudnikObrozovaniy<Obrazovanie>, IObrazovanieRepository
    {
        public ObrazovanieRepository(Models.PP_KADNIKOV3Entities context) : base(context)
        {
        }

        public List<ObrazovanieDto> GetByUserId(int userId)
        {
            return _context.Obrazovanie
                .Where(obrazovanie => obrazovanie.fk_kod_sotrudnika == userId)
                .Select(obrazovanie => new ObrazovanieDto
                {
                    ID_OB = obrazovanie.ID_OB,
                    Образование = obrazovanie.obrazovanie1,
                    Наименование = obrazovanie.nazvanieuchrejdeniya,
                    Квалификация = obrazovanie.kvalifikachiyapoObrazovaniyu,
                    Наименование1 = obrazovanie.nazvanieuchrejdeniya2,
                    Квалификация1 = obrazovanie.kvalifikachiyapoObrazovaniyu2,
                    Послевузовское = obrazovanie.poslevuzovoe,
                    ПрофессияОсновная = obrazovanie.professiaOsnova,
                    ПрофессияДругая = obrazovanie.professiaDopolnitel
                })
                .ToList();
        }
    }
}
