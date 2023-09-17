using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class PassportRepository : IRepository<Models.Passport>
    {
        private Models.PP_KADNIKOV3Entities context;
        private static PassportRepository instance;
        private readonly PP_KADNIKOV3Entities db;
        private PassportRepository()
        {
            db = new PP_KADNIKOV3Entities();
        }

        public static PassportRepository Instance
        {
            get
            {
                if (instance == null)
                    instance = new PassportRepository();

                return instance;
            }
        }

        public async Task<Passport> GetPassportByUserId(int userId)
        {
            return await db.Passport.FirstOrDefaultAsync(p => p.FK_Sotrudnik == userId);
        }

        public async Task AddPassport(int userId, string passportNumber, DateTime vidachi, DateTime registracii, string vidacha, string adress, string adressFackt)
        {
            db.Passport.Add(new Passport
            {
                FK_Sotrudnik = userId,
                nomer_pasporta = passportNumber,
                datavidachi = vidachi,
                dataregistrachii_po_mestu = registracii,
                vidan = vidacha,
                adressjitelstva_popasportu = adress,
                aress_fakticheskiy = adressFackt
            });

            await db.SaveChangesAsync();
        }

        public async Task UpdatePassport(Passport passport, string passportNumber, DateTime vidachi, DateTime registracii, string vidacha, string adress, string adressFackt)
        {
            passport.nomer_pasporta = passportNumber;
            passport.datavidachi = vidachi;
            passport.dataregistrachii_po_mestu = registracii;
            passport.vidan = vidacha;
            passport.adressjitelstva_popasportu = adress;
            passport.aress_fakticheskiy = adressFackt;

            await db.SaveChangesAsync();
        }
    

    public PassportRepository(Models.PP_KADNIKOV3Entities context)
        {
            this.context = context;
        }

        public async Task<Models.Passport> GetFirstOrDefaultAsync(Expression<Func<Models.Passport, bool>> predicate)
        {
            return await context.Passport.FirstOrDefaultAsync(predicate);
        }

        public void Add(Models.Passport passport)
        {
            context.Passport.Add(passport);
        }

        public void Update(Models.Passport passport)
        {
            context.Entry(passport).State = EntityState.Modified;
        }

        public void Delete(Models.Passport passport)
        {
            context.Passport.Remove(passport);
        }
    }
}
