﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABC_Analysis_presenter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Marketingovoe_agentstvoEntities1 : DbContext
    {
        public Marketingovoe_agentstvoEntities1()
            : base("name=Marketingovoe_agentstvoEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Factory> Factories { get; set; }
        public virtual DbSet<Kategory> Kategories { get; set; }
        public virtual DbSet<Napravlenie> Napravlenies { get; set; }
        public virtual DbSet<Opro> Opros { get; set; }
        public virtual DbSet<Parametry> Parametries { get; set; }
        public virtual DbSet<Rezultat_oprosa> Rezultat_oprosa { get; set; }
        public virtual DbSet<Sotrudniki> Sotrudnikis { get; set; }
        public virtual DbSet<Uslugy> Uslugies { get; set; }
    }
}
