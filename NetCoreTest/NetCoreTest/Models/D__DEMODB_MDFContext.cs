using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NetCoreTest.Models
{
    public partial class D__DEMODB_MDFContext : DbContext
    {
        public virtual DbSet<PhoneBook> PhoneBook { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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