using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class ObrazovanieDto
    {
        public int ID_OB { get; set; }
        public string Образование { get; set; }
        public string Наименование { get; set; }
        public string Квалификация { get; set; }
        public string Наименование1 { get; set; }
        public string Квалификация1 { get; set; }
        public string Послевузовское { get; set; }
        public string ПрофессияОсновная { get; set; }
        public string ПрофессияДругая { get; set; }
    }
}
