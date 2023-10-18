using Examen.Base;
using System.Data.Entity;
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

        public async Task<Base.usersProgram> GetUserProgramAsync(int userId)
        {
            return await context.usersProgram.FirstOrDefaultAsync(u => u.ID_dol == userId);
        }
    }
}
