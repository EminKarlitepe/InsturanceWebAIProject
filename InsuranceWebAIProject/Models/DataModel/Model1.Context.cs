﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsuranceWebAIProject.Models.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InsureWebAIDbEntities : DbContext
    {
        public InsureWebAIDbEntities()
            : base("name=InsureWebAIDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<FAQs> FAQs { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }
        public virtual DbSet<Testimonial> Testimonial { get; set; }
        public virtual DbSet<Team> Team { get; set; }
    }
}
