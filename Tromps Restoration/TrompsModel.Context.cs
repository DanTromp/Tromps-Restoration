﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tromps_Restoration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrompsEntities1 : DbContext
    {
        public TrompsEntities1()
            : base("name=TrompsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Hire_Order> Hire_Orders { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Machine_Service> Machine_Services { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
    }
}