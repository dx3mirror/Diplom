using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class AuthorizationModel
    {
        public async Task<Base.usersProgram> AuthenticateUserAsync(string login, string password)
        {
            using (var context = new Base.PP_KADNIKOV3Entities())
            {
                Collect();
                return await context.usersProgram.FirstOrDefaultAsync(u => u.loginI == login && u.PasI == password);
            }
        }

        private void Collect()
        {
            // Лучше избегать явного вызова GC.Collect, он обычно не нужен.
        }
    }
}
