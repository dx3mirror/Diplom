using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class UnitOfWorkStaj : IUnitOfWorkStaj
    {
        private readonly DbContext context;
        private IRepositoryStaj<Experience> experienceRepositoryStaj;

        public UnitOfWorkStaj(DbContext context)
        {
            this.context = context;
            experienceRepositoryStaj = new RepositoryStaj<Experience>(context);
        }

        public IRepositoryStaj<Experience> ExperienceRepository
        {
            get { return experienceRepositoryStaj; }
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}

