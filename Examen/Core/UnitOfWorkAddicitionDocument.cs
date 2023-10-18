using Examen.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class UnitOfWorkAddicitionDocument : IUnitOfWorkAddicitionDocument
    {
        private readonly PP_KADNIKOV3Entities dbContext;

        public UnitOfWorkAddicitionDocument(PP_KADNIKOV3Entities dbContext)
        {
            this.dbContext = dbContext;
            AdditionalDocumentsRepository = new AdditionalDocumentsRepository(dbContext);
        }

        public IAdditionalDocumentsRepository AdditionalDocumentsRepository { get; }

        public Task SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
    }
}
