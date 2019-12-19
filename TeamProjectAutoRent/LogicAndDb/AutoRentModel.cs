namespace LogicAndDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class AutoRentModel : DbContext
    {
        public AutoRentModel()
            : base("name=AutoRentModel")
        {
        }
   
        public virtual DbSet<Accident> Accident { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Car_model> Car_model { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Lease_contract> Lease_contract { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<Purchase_contract> Purchase_contract { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.brand_name)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.price_category)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.mileage)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Car>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.model_name)
                .IsUnicode(false);

            modelBuilder.Entity<Car_model>()
                .Property(e => e.model_name)
                .IsUnicode(false);

            modelBuilder.Entity<Car_model>()
                .Property(e => e.brand_name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.passport_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.phone_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.passport_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lease_contract>()
                .Property(e => e.passport_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lease_contract>()
                .Property(e => e.daily_cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.Lease_contract)
                .WithOptional(e => e.Office)
                .HasForeignKey(e => e.native_office_address);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.Lease_contract1)
                .WithOptional(e => e.Office1)
                .HasForeignKey(e => e.return_office_address);

            modelBuilder.Entity<Purchase_contract>()
                .Property(e => e.passport_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Purchase_contract>()
                .Property(e => e.amount)
                .HasPrecision(18, 0);
        }
    }
}
