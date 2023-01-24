namespace StokOtomasyon.DLL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StokOtomasyonContext : DbContext
    {
        public StokOtomasyonContext()
            : base("name=StokOtomasyonContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Depo> Depoes { get; set; }
        public virtual DbSet<Hareket> Harekets { get; set; }
        public virtual DbSet<Stok> Stoks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Depo>()
                .HasMany(e => e.Harekets)
                .WithRequired(e => e.Depo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stok>()
                .Property(e => e.StokAd)
                .IsFixedLength();

            modelBuilder.Entity<Stok>()
                .HasMany(e => e.Harekets)
                .WithRequired(e => e.Stok)
                .WillCascadeOnDelete(false);
        }
    }
}
