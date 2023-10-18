using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class UnitOfWorkAddSotrudnik : IDisposable
    {
        private Base.PP_KADNIKOV3Entities context;
        private SotrudnikRepositoryAdd sotrudnikRepository;

        public UnitOfWorkAddSotrudnik()
        {
            context = new Base.PP_KADNIKOV3Entities();
        }

        public SotrudnikRepositoryAdd SotrudnikRepository
        {
            get
            {
                if (sotrudnikRepository == null)
                {
                    sotrudnikRepository = new SotrudnikRepositoryAdd(context);
                }
                return sotrudnikRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }

}

