﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppStock.Modeles
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdStockEntities : DbContext
    {
        public bdStockEntities()
            : base("name=bdStockEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<approvisionnement> approvisionnement { get; set; }
        public virtual DbSet<categorie> categorie { get; set; }
        public virtual DbSet<facture> facture { get; set; }
        public virtual DbSet<livraison> livraison { get; set; }
        public virtual DbSet<produit> produit { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<utilisateur> utilisateur { get; set; }
        public virtual DbSet<venteProduit> venteProduit { get; set; }
    }
}