using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class RepositorySotrudnikObrozovaniy<T> : IRepositorySotrudnikObrozovaniy<T> where T : class
    {
        protected readonly Models.PP_KADNIKOV3Entities _context;

        public RepositorySotrudnikObrozovaniy(Models.PP_KADNIKOV3Entities context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
