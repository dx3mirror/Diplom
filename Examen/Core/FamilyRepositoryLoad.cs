using Examen.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class FamilyRepositoryLoad : IFamilyRepository
    {
        private readonly PP_KADNIKOV3Entities dbContext;

        public FamilyRepositoryLoad(PP_KADNIKOV3Entities dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<FamilyDto>> GetFamilyByUserId(int userId)
        {
            var query = from f in dbContext.Family
                        where f.FK_sotrudnik == userId
                        select new FamilyDto
                        {
                            ID = f.ID,
                            ФИО = f.FIO,
                            Степеньродства = f.stepen_rodstva,
                            Датарождения = f.data_rojdeniya.HasValue ? f.data_rojdeniya.Value : DateTime.MinValue
                        };

            return await query.ToListAsync();
        }
    }
}
