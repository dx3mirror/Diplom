using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class UnitOfWorkDelete : IDisposable
    {
        private Base.PP_KADNIKOV3Entities context;
        private DbContextTransaction transaction;

        public UnitOfWorkDelete()
        {
            context = new Base.PP_KADNIKOV3Entities();
            transaction = context.Database.BeginTransaction();
        }

        public Base.PP_KADNIKOV3Entities Context
        {
            get { return context; }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void Dispose()
        {
            transaction.Dispose();
            context.Dispose();
        }
    }
}
