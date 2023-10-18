using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class UnitOfWorkUpdate : IUnitOfWorkUpdate
    {
        private readonly Base.PP_KADNIKOV3Entities _context;
        private ISotrudnikRepositoryUpdate _sotrudnikRepositoryUpdate;

        public UnitOfWorkUpdate()
        {
            _context = new Base.PP_KADNIKOV3Entities();
        }

        public ISotrudnikRepositoryUpdate SotrudnikRepositoryUpdate
        {
            get
            {
                if (_sotrudnikRepositoryUpdate == null)
                {
                    _sotrudnikRepositoryUpdate = new SotrudnikRepositoryUpdate(_context);
                }
                return _sotrudnikRepositoryUpdate;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
