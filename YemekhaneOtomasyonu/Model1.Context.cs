﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YemekhaneOtomasyonu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Yemekhane_OtomasyonEntities : DbContext
    {
        public Yemekhane_OtomasyonEntities()
            : base("name=Yemekhane_OtomasyonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HaftalıkYemek> HaftalıkYemek { get; set; }
        public virtual DbSet<KullancıBakiye> KullancıBakiye { get; set; }
        public virtual DbSet<Kullanıcı> Kullanıcı { get; set; }
        public virtual DbSet<KullanıcıYetki> KullanıcıYetki { get; set; }
        public virtual DbSet<Yemek> Yemek { get; set; }
    }
}
