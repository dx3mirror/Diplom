using Examen.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class SotrudnikRepository : ISotrudnikRepository 
    {

        private readonly PP_KADNIKOV3Entities dbContext;

        public SotrudnikRepository(PP_KADNIKOV3Entities dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Sotrudnik>> GetAllSotrudniki(bool deletedOnly = false)
        {
            var customSelect =
               @"SELECT ID
               ,[lastname] 
               ,[nam] 
               ,[patronomic] 
               ,[mesto_rojd] 
               ,[telefon] 
               ,adress
               ,[datarojdeniya] 
               ,[in_yaz] 
               ,[mestorojdenia]
               ,[uvolen]
               ,[grajdanstvo] 
               ,[Pol]
               ,[Identitynomer] 
               ,[OKIN] 
               ,[brak] 
               ,[del] 
           FROM [dbo].[Sotrudnik] ";

            if (deletedOnly)
                customSelect += " WHERE del = 'yes'";
            else
                customSelect += " WHERE del = 'no'";

            return await dbContext.Database.SqlQuery<Sotrudnik>(customSelect).ToListAsync();
        }
    }
}
