﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otobus_Otomasyon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OBSODBEntities : DbContext
    {
        public OBSODBEntities()
            : base("name=OBSODBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Araclar> Araclar { get; set; }
        public virtual DbSet<Biletler> Biletler { get; set; }
        public virtual DbSet<Koltuklar> Koltuklar { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<Mesafeler> Mesafeler { get; set; }
        public virtual DbSet<OdemeKayitlari> OdemeKayitlari { get; set; }
        public virtual DbSet<Seferler> Seferler { get; set; }
        public virtual DbSet<Sehirler> Sehirler { get; set; }
        public virtual DbSet<SifreSifirlamaTokeni> SifreSifirlamaTokeni { get; set; }
        public virtual DbSet<Yolcular> Yolcular { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual ObjectResult<SeferListesi_Result> SeferListesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SeferListesi_Result>("SeferListesi");
        }
    
        public virtual ObjectResult<BiletListesi_Result2> BiletListesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BiletListesi_Result2>("BiletListesi");
        }
    
        public virtual ObjectResult<RezervasyonListesi_Result> RezervasyonListesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RezervasyonListesi_Result>("RezervasyonListesi");
        }
    }
}
