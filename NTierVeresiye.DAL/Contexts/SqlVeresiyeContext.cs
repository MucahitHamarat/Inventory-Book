using NTierVeresiye.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierVeresiye.DAL.Contexts
{
    public class SqlVeresiyeContext:DbContext
    {
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Tedarikci> Tedarikci { get; set; }
        public DbSet<Urun> Urun { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.ID).//1
              HasColumnType("int").IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.Ad).//2
                HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.Soyad).//3
                HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.SabitTelefon).//4
              HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.CepTelefon).//5
               HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.FaxTelefon).//6
              HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.email).//7
              HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.TC).//8
               HasColumnType("varchar").HasMaxLength(11).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.Aciklama).//9
               HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.Adres).//10
               HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.SabitTelefon).//11
              HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Musteri>().ToTable("Müşteri").Property(p => p.Unvan).//12
              HasColumnType("varchar").HasMaxLength(50).IsRequired();

            modelBuilder.Types().Configure(c => c.MapToStoredProcedures());

        }
    }
}
