﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RentAcarEntities1 : DbContext
    {
        public RentAcarEntities1()
            : base("name=RentAcarEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Inspeccion> Inspeccions { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<RentaDevolucion> RentaDevolucions { get; set; }
        public virtual DbSet<TiposDecombustible> TiposDecombustibles { get; set; }
        public virtual DbSet<TiposDeVehiculo> TiposDeVehiculos { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehiculo> Vehiculoes { get; set; }
        public virtual DbSet<Modelo> Modelos { get; set; }
    }
}
