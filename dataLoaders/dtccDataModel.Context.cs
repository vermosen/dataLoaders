﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dataLoader
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dataRepositoryEntities : DbContext
    {
        public dataRepositoryEntities()
            : base("name=dataRepositoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<asset_class> asset_class { get; set; }
        public virtual DbSet<dtcc_transactions> dtcc_transactions { get; set; }
        public virtual DbSet<indication_of_collateralization> indication_of_collateralization { get; set; }
    }
}
