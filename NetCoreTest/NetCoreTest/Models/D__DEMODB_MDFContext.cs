using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCoreTest.Models
{
    public partial class D__DEMODB_MDFContext : DbContext
    {
        public virtual DbSet<Emails> Emails { get; set; }
        public virtual DbSet<PhoneBook> PhoneBook { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DemoDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emails>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasColumnName("EMAIL");

                entity.Property(e => e.Person)
                    .HasColumnName("PERSON")
                    .HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<PhoneBook>(entity =>
            {
                entity.Property(e => e.Person)
                    .HasColumnName("PERSON")
                    .HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber)
                    .HasColumnName("TELEPHONE_NUMBER")
                    .HasColumnType("nchar(10)");
            });
        }
    }
}