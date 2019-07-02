namespace Love.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LoveDataContext : DbContext
    {
        public LoveDataContext()
            : base("name=LoveDataContext2")
        {
        }

        public virtual DbSet<Anketa> Anketa { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Uvlechenia> Uvlechenia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anketa>()
                .Property(e => e.Pol)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Anketa)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Uvlechenia>()
                .HasMany(e => e.Anketa)
                .WithOptional(e => e.Uvlechenia)
                .HasForeignKey(e => e.UvlecheniaiId);
        }
    }
}
