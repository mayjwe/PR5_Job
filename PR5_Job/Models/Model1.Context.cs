﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR5_Job.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AtelierEntities : DbContext
    {
        public AtelierEntities()
            : base("name=AtelierEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accessories> Accessories { get; set; }
        public virtual DbSet<Authorization> Authorization { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Cloth> Cloth { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Color_Accessories> Color_Accessories { get; set; }
        public virtual DbSet<Density> Density { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<More> More { get; set; }
        public virtual DbSet<Ordedrs> Ordedrs { get; set; }
        public virtual DbSet<Queue> Queue { get; set; }
        public virtual DbSet<Repair_requests> Repair_requests { get; set; }
        public virtual DbSet<Resistance> Resistance { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Status_model> Status_model { get; set; }
        public virtual DbSet<Status_order> Status_order { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}