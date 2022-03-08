using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Bank.DTO;
namespace Bank
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TCredits> Credits { get; set; }
        public DbSet<TDeposits> Deposits { get; set; }

        public DbSet<TClients> Clients { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
             : base(options)
        {
           // Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<TCredits>(entity =>
        //    {
        //        entity.HasKey(e => e.IDCredit);
        //        entity.Property(e => e.IDCredit).ValueGeneratedOnAdd();
        //        entity.ToTable("TCredits");
        //    });

        //    modelBuilder.Entity<TDeposits>(entity =>
        //    {
        //        entity.HasKey(e => e.IDDeposit);
        //        entity.Property(e => e.IDDeposit).ValueGeneratedOnAdd();
        //        entity.ToTable("TDeposits");
        //    });

        //    modelBuilder.Entity<TClients>(entity =>
        //    {
        //        entity.HasKey(e => e.IDClient);
        //        entity.Property(e => e.IDClient).ValueGeneratedOnAdd();
        //        entity.ToTable("TClients");
        //    });


        //    modelBuilder.Entity<TClients>()
        //        .HasKey(entity => entity.IDClient);

        //    modelBuilder.Entity<TClients>()
        //        .HasOne(record => record.Credit)
        //        .WithMany(enti => enti.CreditTClients)
        //        .HasForeignKey(record => record.CreditId);

        //    modelBuilder.Entity<TClients>()
        //        .HasOne(a => a.Deposit)
        //        .WithMany(b => b.DepositsTClients)
        //        .HasForeignKey(c => c.DepositId);


        //}
    }
}
