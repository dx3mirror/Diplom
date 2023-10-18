using Examen.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class UnitOfWorkWarUchet : IUnitOfWorkWarUchet
    {
        private readonly PP_KADNIKOV3Entities _context;
        private IWaruchetRepository _waruchetRepository;

        public UnitOfWorkWarUchet(PP_KADNIKOV3Entities context)
        {
            _context = context;
        }

        public IWaruchetRepository WaruchetRepository
        {
            get
            {
                if (_waruchetRepository == null)
                {
                    _waruchetRepository = new WaruchetRepository(_context);
                }
                return _waruchetRepository;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
