﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workshop_5_Group_3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TravelExpertsEntities : DbContext
    {
        public TravelExpertsEntities()
            : base("name=TravelExpertsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Affiliation> Affiliations { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customers_Rewards> Customers_Rewards { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Products_Suppliers> Products_Suppliers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<SupplierContact> SupplierContacts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<TripType> TripTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
