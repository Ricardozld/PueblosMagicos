﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sistemarecomendacionEntities : DbContext
    {
        public sistemarecomendacionEntities()
            : base("name=sistemarecomendacionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<atractivo> atractivo { get; set; }
        public virtual DbSet<atractivo_has_criterios_evaluacion> atractivo_has_criterios_evaluacion { get; set; }
        public virtual DbSet<calificacion> calificacion { get; set; }
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<criterios_evaluacion> criterios_evaluacion { get; set; }
        public virtual DbSet<entidad_federativa> entidad_federativa { get; set; }
        public virtual DbSet<historial_visitas> historial_visitas { get; set; }
        public virtual DbSet<pueblo_magico> pueblo_magico { get; set; }
        public virtual DbSet<tipo_atractivo> tipo_atractivo { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
