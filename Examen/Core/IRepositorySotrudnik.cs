﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public interface IRepositorySotrudnik<T> where T : class
    {
        void Add(T entity);
        Task SaveChangesAsync();
        List<T> GetAll();
        void Delete(T entity);
    }
}