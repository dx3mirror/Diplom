using Examen.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class FamilyRepository
    {
        private readonly PP_KADNIKOV3Entities _context;

        public FamilyRepository(PP_KADNIKOV3Entities context)
        {
            _context = context;
        }

        public async Task<Family> GetById(int id)
        {
            return await _context.Family.FirstOrDefaultAsync(f => f.ID == id);
        }

        public IEnumerable<FamilyDto> GetByUserId(int userId)
        {
            return _context.Family
                .Where(f => f.FK_sotrudnik == userId)
                .Select(f => new FamilyDto
                {
                    ID = f.ID,
                    ФИО = f.FIO,
                    Степеньродства = f.stepen_rodstva,
                    Датарождения = f.data_rojdeniya.HasValue ? f.data_rojdeniya.Value : DateTime.MinValue
                })
                .ToList();
        }

        public void AddFamily(Family family)
        {
            _context.Family.Add(family);
        }

        public void RemoveFamily(Family family)
        {
            _context.Family.Remove(family);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
