using Examen.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class SotrudnikRepositoryUpdate : ISotrudnikRepositoryUpdate
    {
        private readonly Base.PP_KADNIKOV3Entities _context;

        public SotrudnikRepositoryUpdate(Base.PP_KADNIKOV3Entities context)
        {
            _context = context;
        }

        public async Task<Sotrudnik> GetById(int id)
        {
            return await _context.Sotrudnik.FindAsync(id);
        }

        public async Task Update(Sotrudnik sotrudnik)
        {
            await _context.SaveChangesAsync();
        }
    }
}
