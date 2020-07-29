using System;
using System.IO;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace drontaxi.Models
{
    public partial class drontaxiContext : DbContext
    {
        public drontaxiContext()
        {
        }

        public drontaxiContext(DbContextOptions<drontaxiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalAttribute> AdditionalAttribute { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<Master> Master { get; set; }
        public virtual DbSet<OrderOfUser> OrderOfUser { get; set; }
        public virtual DbSet<RepairCycle> RepairCycle { get; set; }
        public virtual DbSet<Repairs> Repairs { get; set; }
        public virtual DbSet<RoleForUser> RoleForUser { get; set; }
        public virtual DbSet<SaveUseraccount> SaveUseraccount { get; set; }
        public virtual DbSet<SystemFunction> SystemFunction { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<TransportComplectation> TransportComplectation { get; set; }
        public virtual DbSet<TransportPhoto> TransportPhoto { get; set; }
        public virtual DbSet<Useraccount> Useraccount { get; set; }
        public virtual DbSet<СycleOfTechnicalInspections> СycleOfTechnicalInspections { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //var jsonString = File.ReadAllText("databasedata.json");
                //DatabaseConnect databaseConnect = JsonSerializer.Deserialize<DatabaseConnect>(jsonString);
                //optionsBuilder.UseNpgsql($"Host={databaseConnect.Host};Port={databaseConnect.Port};Database={databaseConnect.Database};Username={databaseConnect.Username};Password={databaseConnect.Password}");
                optionsBuilder.UseNpgsql($"Host=10.0.0.3;Port=5432;Database=drontaxi;Username=andrey;Password=1469");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionalAttribute>(entity =>
            {
                entity.HasKey(e => e.IdAttribute)
                    .HasName("additional_attribute_pkey");

                entity.ToTable("additional_attribute");

                entity.Property(e => e.IdAttribute).HasColumnName("id_attribute");

                entity.Property(e => e.Attribute)
                    .IsRequired()
                    .HasColumnName("attribute")
                    .HasMaxLength(50);

                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasColumnName("attribute_value")
                    .HasMaxLength(50);

                entity.Property(e => e.Transport)
                    .HasColumnName("transport")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.TransportNavigation)
                    .WithMany(p => p.AdditionalAttribute)
                    .HasForeignKey(d => d.Transport)
                    .HasConstraintName("additional_attribute_transport_fkey");
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.HasKey(e => e.IdMaintenance)
                    .HasName("maintenance_pkey");

                entity.ToTable("maintenance");

                entity.Property(e => e.IdMaintenance).HasColumnName("id_maintenance");

                entity.Property(e => e.DateOfMaintenance)
                    .HasColumnName("date_of_maintenance")
                    .HasColumnType("date");

                entity.Property(e => e.InspectionResult)
                    .IsRequired()
                    .HasColumnName("inspection_result")
                    .HasMaxLength(30);

                entity.Property(e => e.Master)
                    .HasColumnName("master")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Transport)
                    .HasColumnName("transport")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.MasterNavigation)
                    .WithMany(p => p.Maintenance)
                    .HasForeignKey(d => d.Master)
                    .HasConstraintName("maintenance_master_fkey");

                entity.HasOne(d => d.TransportNavigation)
                    .WithMany(p => p.Maintenance)
                    .HasForeignKey(d => d.Transport)
                    .HasConstraintName("maintenance_transport_fkey");
            });

            modelBuilder.Entity<Master>(entity =>
            {
                entity.HasKey(e => e.IdMaster)
                    .HasName("master_pkey");

                entity.ToTable("master");

                entity.Property(e => e.IdMaster).HasColumnName("id_master");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(30);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(30);

                entity.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasColumnName("patronymic")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<OrderOfUser>(entity =>
            {
                entity.HasKey(e => e.NumberOfOrder)
                    .HasName("order_of_user_pkey");

                entity.ToTable("order_of_user");

                entity.Property(e => e.NumberOfOrder).HasColumnName("number_of_order");

                entity.Property(e => e.Customer)
                    .HasColumnName("customer")
                    .HasMaxLength(50);

                entity.Property(e => e.DatetimeOfOrder).HasColumnName("datetime_of_order");

                entity.Property(e => e.DeparturePointAddress)
                    .IsRequired()
                    .HasColumnName("departure_point_address")
                    .HasMaxLength(100);

                entity.Property(e => e.DestinationAddress)
                    .IsRequired()
                    .HasColumnName("destination_address")
                    .HasMaxLength(100);

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(30);

                entity.Property(e => e.Transport)
                    .HasColumnName("transport")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.OrderOfUserCustomerNavigation)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("order_of_user_customer_fkey");

                entity.HasOne(d => d.OperatorNavigation)
                    .WithMany(p => p.OrderOfUserOperatorNavigation)
                    .HasForeignKey(d => d.Operator)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("order_of_user_operator_fkey");

                entity.HasOne(d => d.TransportNavigation)
                    .WithMany(p => p.OrderOfUser)
                    .HasForeignKey(d => d.Transport)
                    .HasConstraintName("order_of_user_transport_fkey");
            });

            modelBuilder.Entity<RepairCycle>(entity =>
            {
                entity.HasKey(e => e.IdRepairCycle)
                    .HasName("repair_cycle_pkey");

                entity.ToTable("repair_cycle");

                entity.Property(e => e.IdRepairCycle).HasColumnName("id_repair_cycle");

                entity.Property(e => e.PeriodicityType)
                    .IsRequired()
                    .HasColumnName("periodicity_type")
                    .HasMaxLength(30);

                entity.Property(e => e.PeriodicityValue).HasColumnName("periodicity_value");
            });

            modelBuilder.Entity<Repairs>(entity =>
            {
                entity.HasKey(e => e.IdRepairs)
                    .HasName("repairs_pkey");

                entity.ToTable("repairs");

                entity.Property(e => e.IdRepairs).HasColumnName("id_repairs");

                entity.Property(e => e.DateOfRepairs)
                    .HasColumnName("date_of_repairs")
                    .HasColumnType("date");

                entity.Property(e => e.Master)
                    .HasColumnName("master")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NatureOfFailure)
                    .IsRequired()
                    .HasColumnName("nature_of_failure")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeOfRepairs)
                    .IsRequired()
                    .HasColumnName("type_of_repairs")
                    .HasMaxLength(50);

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.MasterNavigation)
                    .WithMany(p => p.Repairs)
                    .HasForeignKey(d => d.Master)
                    .HasConstraintName("repairs_master_fkey");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.Repairs)
                    .HasForeignKey(d => d.Unit)
                    .HasConstraintName("repairs_unit_fkey");
            });

            modelBuilder.Entity<RoleForUser>(entity =>
            {
                entity.HasKey(e => e.SystemName)
                    .HasName("role_for_user_pkey");

                entity.ToTable("role_for_user");

                entity.Property(e => e.SystemName)
                    .HasColumnName("system_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expiration_date")
                    .HasColumnType("date");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("role_name")
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.RoleForUser)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("role_for_user_email_fkey");
            });

            modelBuilder.Entity<SaveUseraccount>(entity =>
            {
                entity.ToTable("save_useraccount");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.SaveUseraccount)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("save_useraccount_email_fkey");
            });

            modelBuilder.Entity<SystemFunction>(entity =>
            {
                entity.HasKey(e => e.SystemName)
                    .HasName("system_function_pkey");

                entity.ToTable("system_function");

                entity.Property(e => e.SystemName)
                    .HasColumnName("system_name")
                    .HasMaxLength(50);

                entity.Property(e => e.FunctionName)
                    .IsRequired()
                    .HasColumnName("function_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(50);

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.SystemFunction)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("system_function_role_fkey");
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.HasKey(e => e.IdTransport)
                    .HasName("transport_pkey");

                entity.ToTable("transport");

                entity.Property(e => e.IdTransport).HasColumnName("id_transport");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("brand")
                    .HasMaxLength(30);

                entity.Property(e => e.CycleOfTechnicalInspections)
                    .HasColumnName("cycle_of_technical_inspections")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateOfRegistration)
                    .HasColumnName("date_of_registration")
                    .HasColumnType("date");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(30);

                entity.Property(e => e.NumberOfRegistrtion)
                    .IsRequired()
                    .HasColumnName("number_of_registrtion")
                    .HasMaxLength(50);

                entity.Property(e => e.RepairCycle)
                    .HasColumnName("repair_cycle")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TransportStatus)
                    .IsRequired()
                    .HasColumnName("transport_status")
                    .HasMaxLength(50);

                entity.Property(e => e.WriteoffDate)
                    .HasColumnName("writeoff_date")
                    .HasColumnType("date");

                entity.Property(e => e.YearOfProduction).HasColumnName("year_of_production");

                entity.HasOne(d => d.CycleOfTechnicalInspectionsNavigation)
                    .WithMany(p => p.Transport)
                    .HasForeignKey(d => d.CycleOfTechnicalInspections)
                    .HasConstraintName("transport_cycle_of_technical_inspections_fkey");

                entity.HasOne(d => d.RepairCycleNavigation)
                    .WithMany(p => p.Transport)
                    .HasForeignKey(d => d.RepairCycle)
                    .HasConstraintName("transport_repair_cycle_fkey");
            });

            modelBuilder.Entity<TransportComplectation>(entity =>
            {
                entity.HasKey(e => e.IdUnit)
                    .HasName("transport_complectation_pkey");

                entity.ToTable("transport_complectation");

                entity.Property(e => e.IdUnit).HasColumnName("id_unit");

                entity.Property(e => e.Transport)
                    .HasColumnName("transport")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasColumnName("unit_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.TransportNavigation)
                    .WithMany(p => p.TransportComplectation)
                    .HasForeignKey(d => d.Transport)
                    .HasConstraintName("transport_complectation_transport_fkey");
            });

            modelBuilder.Entity<TransportPhoto>(entity =>
            {
                entity.HasKey(e => e.Transport)
                    .HasName("transport_photo_pkey");

                entity.ToTable("transport_photo");

                entity.Property(e => e.Transport)
                    .HasColumnName("transport")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(150);

                entity.HasOne(d => d.TransportNavigation)
                    .WithOne(p => p.TransportPhoto)
                    .HasForeignKey<TransportPhoto>(d => d.Transport)
                    .HasConstraintName("transport_photo_transport_fkey");
            });

            modelBuilder.Entity<Useraccount>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("useraccount_pkey");

                entity.ToTable("useraccount");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("date");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(30);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(20);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(30);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasColumnName("patronymic")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(30);

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnName("photo")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<СycleOfTechnicalInspections>(entity =>
            {
                entity.HasKey(e => e.IdTechnicalInspections)
                    .HasName("Сycle_of_technical_inspections_pkey");

                entity.ToTable("Сycle_of_technical_inspections");

                entity.Property(e => e.IdTechnicalInspections).HasColumnName("id_technical_inspections");

                entity.Property(e => e.PeriodicityType)
                    .IsRequired()
                    .HasColumnName("periodicity_type")
                    .HasMaxLength(30);

                entity.Property(e => e.PeriodicityValue)
                    .IsRequired()
                    .HasColumnName("periodicity_value")
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
