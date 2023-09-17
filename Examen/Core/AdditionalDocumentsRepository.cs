using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class AdditionalDocumentsRepository : IAdditionalDocumentsRepository
    {
        private readonly PP_KADNIKOV3Entities dbContext;

        public AdditionalDocumentsRepository(PP_KADNIKOV3Entities dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<AdditionalDocuments> GetByUserId(int userId)
        {
            return dbContext.AdditionalDocuments.FirstOrDefaultAsync(ad => ad.fk == userId);
        }

        public Task AddOrUpdate(AdditionalDocuments additionalDocuments)
        {
            if (additionalDocuments.ID == 0)
            {
                dbContext.AdditionalDocuments.Add(additionalDocuments);
            }
            else
            {
                dbContext.AdditionalDocuments.AddOrUpdate(additionalDocuments);
            }

            return dbContext.SaveChangesAsync();
        }
    }
}
