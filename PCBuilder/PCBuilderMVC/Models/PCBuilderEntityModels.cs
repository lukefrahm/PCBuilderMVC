namespace PCBuilderMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// PCBuilder Entity Framework Models view model class.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public partial class PCBuilderEntityModels : DbContext
    {
        public PCBuilderEntityModels()
            : base("name=PCBuilderEntityModels")
        {
        }

        public virtual DbSet<CPU> CPUs { get; set; }
        public virtual DbSet<GPU> GPUs { get; set; }
        public virtual DbSet<Motherboard> Motherboards { get; set; }
        public virtual DbSet<Optical> Opticals { get; set; }
        public virtual DbSet<PSU> PSUs { get; set; }
        public virtual DbSet<RAM> RAMs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CPU>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<CPU>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<CPU>()
                .Property(e => e.Socket)
                .IsUnicode(false);

            modelBuilder.Entity<CPU>()
                .Property(e => e.ProductLineName)
                .IsUnicode(false);

            modelBuilder.Entity<CPU>()
                .Property(e => e.BestUse)
                .IsUnicode(false);

            modelBuilder.Entity<CPU>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<GPU>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.ProductLineName)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.BestUse)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.GpuLength)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Socket)
                .IsUnicode(false);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Chipset)
                .IsUnicode(false);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.FormFactor)
                .IsUnicode(false);

            modelBuilder.Entity<Motherboard>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Optical>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<Optical>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Optical>()
                .Property(e => e.OpticalType)
                .IsUnicode(false);

            modelBuilder.Entity<Optical>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<PSU>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<PSU>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<PSU>()
                .Property(e => e.Efficiency)
                .IsUnicode(false);

            modelBuilder.Entity<PSU>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<RAM>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<RAM>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<RAM>()
                .Property(e => e.RamTimings)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RAM>()
                .Property(e => e.BestUse)
                .IsUnicode(false);

            modelBuilder.Entity<RAM>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .Property(e => e.Brand)
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .Property(e => e.StorageType)
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .Property(e => e.BestUse)
                .IsUnicode(false);

            modelBuilder.Entity<Storage>()
                .Property(e => e.Price)
                .HasPrecision(7, 2);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.StateCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LocalPhone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.RoleName)
                .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<PCBuilderMVC.Models.QuestionnaireViewModel> QuestionnaireViewModels { get; set; }

        public System.Data.Entity.DbSet<PCBuilderMVC.Models.FinalizedBuildViewModel> FinalizedBuildViewModels { get; set; }

        public System.Data.Entity.DbSet<PCBuilderMVC.Models.AspNetUser> AspNetUsers { get; set; }

        public System.Data.Entity.DbSet<PCBuilderMVC.Models.AspNetRole> AspNetRoles { get; set; }
    }
}
