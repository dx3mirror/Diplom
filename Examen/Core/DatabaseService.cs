using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class DatabaseService : IDatabaseService
    {
        private PP_KADNIKOV3Entities context;

        public DatabaseService()
        {
            context = new PP_KADNIKOV3Entities();
        }

        public async Task<Models.usersProgram> GetUserProgramAsync(int userId)
        {
            return await context.usersProgram.FirstOrDefaultAsync(u => u.ID_dol == userId);
        }
    }
}
