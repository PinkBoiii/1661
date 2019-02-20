namespace _1661.Models.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<MyStorege> MyStoreges { get; set; }
        public virtual DbSet<SF> SFs { get; set; }
        public virtual DbSet<ST> STs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyStorege>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<MyStorege>()
                .Property(e => e.NameOfRP)
                .IsUnicode(false);

            modelBuilder.Entity<SF>()
                .Property(e => e.StorageFeatures)
                .IsUnicode(false);

            modelBuilder.Entity<SF>()
                .HasMany(e => e.MyStoreges)
                .WithOptional(e => e.SF)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ST>()
                .Property(e => e.StorageType)
                .IsUnicode(false);

            modelBuilder.Entity<ST>()
                .HasMany(e => e.MyStoreges)
                .WithOptional(e => e.ST)
                .WillCascadeOnDelete();
        }
    }
}
