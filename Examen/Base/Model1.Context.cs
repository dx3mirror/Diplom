﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen.Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PP_KADNIKOV3Entities : DbContext
    {
        public PP_KADNIKOV3Entities()
            : base("name=PP_KADNIKOV3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdditionalDocuments> AdditionalDocuments { get; set; }
        public virtual DbSet<doljnost> doljnost { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Family> Family { get; set; }
        public virtual DbSet<Obrazovanie> Obrazovanie { get; set; }
        public virtual DbSet<Otpusk> Otpusk { get; set; }
        public virtual DbSet<Passport> Passport { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudnik { get; set; }
        public virtual DbSet<Transactionprogram> Transactionprogram { get; set; }
        public virtual DbSet<usersProgram> usersProgram { get; set; }
        public virtual DbSet<Waruchet> Waruchet { get; set; }
        public virtual DbSet<ZayvleniyJob> ZayvleniyJob { get; set; }
    }
}
