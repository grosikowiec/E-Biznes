﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reservations.App_Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LuxStayReservationEntities : DbContext
    {
        public LuxStayReservationEntities()
            : base("name=LuxStayReservationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accommodations> Accommodations { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Rooms_pictures> Rooms_pictures { get; set; }
        public virtual DbSet<User_accommodations> User_accommodations { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
