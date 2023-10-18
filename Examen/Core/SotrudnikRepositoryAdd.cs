using Examen.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class SotrudnikRepositoryAdd : IRepositorySotrudnik<Sotrudnik>
    {
        private Base.PP_KADNIKOV3Entities context;

        public SotrudnikRepositoryAdd(Base.PP_KADNIKOV3Entities context)
        {
            this.context = context;
        }

        public void Add(Sotrudnik entity)
        {
            context.Sotrudnik.Add(entity);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public List<Sotrudnik> GetAll()
        {
            return context.Sotrudnik.ToList();
        }

        public void Delete(Sotrudnik entity)
        {
            context.Sotrudnik.Remove(entity);
        }
    }
}
