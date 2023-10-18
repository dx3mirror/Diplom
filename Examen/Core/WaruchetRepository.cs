using Examen.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class WaruchetRepository : IWaruchetRepository
    {
        private readonly PP_KADNIKOV3Entities _context;

        public WaruchetRepository(PP_KADNIKOV3Entities context)
        {
            _context = context;
        }

        public async Task<List<Waruchet>> GetWaruchetByUserId(int userId)
        {
            return await _context.Waruchet.Where(w => w.FK_sotrudnik == userId).ToListAsync();
        }

        public async Task AddWaruchet(Waruchet waruchet)
        {
            _context.Waruchet.Add(waruchet);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateWaruchet(Waruchet waruchet)
        {
            _context.Entry(waruchet).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteWaruchet(int id)
        {
            var waruchet = await _context.Waruchet.FindAsync(id);
            if (waruchet != null)
            {
                _context.Waruchet.Remove(waruchet);
                await _context.SaveChangesAsync();
            }
        }
    }
}
