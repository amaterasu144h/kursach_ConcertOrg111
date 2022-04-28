using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace kursach_ConcertOrg111.Model
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<ConcertOrganization> ConcertOrganization { get; set; }
        public virtual DbSet<Executor> Executor { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<GenresOfMusic> GenresOfMusic { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserTicket> UserTicket { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConcertOrganization>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ConcertOrganization>()
                .Property(e => e.ExecutorId)
                .IsFixedLength();

            modelBuilder.Entity<ConcertOrganization>()
                .HasOptional(e => e.UserTicket)
                .WithRequired(e => e.ConcertOrganization);

            modelBuilder.Entity<Executor>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<Executor>()
                .HasMany(e => e.ConcertOrganization)
                .WithRequired(e => e.Executor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genres>()
                .HasMany(e => e.ConcertOrganization)
                .WithRequired(e => e.Genres)
                .HasForeignKey(e => e.GenersOfMusicId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GenresOfMusic>()
                .HasMany(e => e.ConcertOrganization)
                .WithRequired(e => e.GenresOfMusic)
                .HasForeignKey(e => e.GenersOfMusicId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Place>()
                .HasMany(e => e.ConcertOrganization)
                .WithRequired(e => e.Place)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Price>()
                .Property(e => e.Price1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Price>()
                .HasMany(e => e.ConcertOrganization)
                .WithRequired(e => e.Price1)
                .HasForeignKey(e => e.PriceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.ConcertOrganizationId)
                .IsFixedLength();

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.ConcertOrganization)
                .WithRequired(e => e.Ticket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTicket>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
