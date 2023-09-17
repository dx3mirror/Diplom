﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class DataAccess : IDataAccess
    {
        private readonly Models.PP_KADNIKOV3Entities _context;

        public DataAccess()
        {
            _context = new Models.PP_KADNIKOV3Entities();
        }

        public async Task AddObrazovanie(Models.Obrazovanie obrazovanie)
        {
            _context.Obrazovanie.Add(obrazovanie);
            await _context.SaveChangesAsync();
        }

        public async Task<Models.Obrazovanie> GetObrazovanieById(int obrazovanieId)
        {
            return await _context.Obrazovanie.FindAsync(obrazovanieId);
        }

        public async Task UpdateObrazovanie(Models.Obrazovanie obrazovanie)
        {
            _context.Entry(obrazovanie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteObrazovanie(int obrazovanieId)
        {
            var obrazovanie = await _context.Obrazovanie.FindAsync(obrazovanieId);
            _context.Obrazovanie.Remove(obrazovanie);
            await _context.SaveChangesAsync();
        }
    }
}