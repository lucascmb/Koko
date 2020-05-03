using Microsoft.EntityFrameworkCore;
using Koko.Domain.Models;

namespace Koko.Persistence.Contexts
{
    public class GorilaDbContext : DbContext
    {
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Depoiment> Depoiments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Investor> Investors { get; set; }

        public GorilaDbContext(DbContextOptions<GorilaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Advisor>().ToTable("Advisors");

            builder.Entity<Advisor>().HasKey(p => p.Id);

            builder.Entity<Advisor>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Advisor>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Advisor>().Property(p => p.HeritageAmount).IsRequired();
            builder.Entity<Advisor>().Property(p => p.ClientAmount).IsRequired();
            builder.Entity<Advisor>().Property(p => p.Rentability).IsRequired();
            builder.Entity<Advisor>().Property(p => p.Email).IsRequired();
            builder.Entity<Advisor>().Property(p => p.AdvisorsOffice).IsRequired();
            builder.Entity<Advisor>().Property(p => p.OpenForNewClients).IsRequired();
            builder.Entity<Advisor>().Property(p => p.Curriculum).IsRequired();

            builder.Entity<Advisor>().HasMany(p => p.Clients).WithOne(p => p.Advisor).HasForeignKey(p => p.AdvisorId);
            builder.Entity<Advisor>().HasMany(p => p.Products).WithOne(p => p.Advisor).HasForeignKey(p => p.AdvisorId);
            builder.Entity<Advisor>().HasMany(p => p.Depoiment).WithOne(p => p.Advisor).HasForeignKey(p => p.AdvisorId);




            builder.Entity<Client>().ToTable("Clients");

            builder.Entity<Client>().HasKey(p => p.Id);

            builder.Entity<Client>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Entity<Client>().HasMany(p => p.Products).WithOne(p => p.Client).HasForeignKey(p => p.ClientId);




            builder.Entity<Investor>().ToTable("Investors");

            builder.Entity<Investor>().HasKey(p => p.Id);

            builder.Entity<Investor>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Investor>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Investor>().Property(p => p.Balance).IsRequired();
            builder.Entity<Investor>().Property(p => p.Objective).IsRequired();
            builder.Entity<Investor>().Property(p => p.Suitability).IsRequired();
            builder.Entity<Investor>().Property(p => p.Email).IsRequired();
            builder.Entity<Investor>().Property(p => p.Telephone).IsRequired();
            builder.Entity<Investor>().Property(p => p.ExpectRentability).IsRequired();
            builder.Entity<Investor>().Property(p => p.Password).IsRequired();
            builder.Entity<Investor>().Property(p => p.InvestmentHorizon).IsRequired();

            //builder.Entity<Investor>().HasMany(p => p.Contacts).WithOne(p => p.Investor).HasForeignKey(p => p.InvestorId);


            builder.Entity<Product>().ToTable("Products");

            builder.Entity<Product>().HasKey(p => p.Id);

            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.ProductType).IsRequired();
            builder.Entity<Product>().Property(p => p.Amount).IsRequired();
            builder.Entity<Product>().Property(p => p.ValueAmount).IsRequired();




            builder.Entity<Depoiment>().ToTable("Depoiment");

            builder.Entity<Depoiment>().HasKey(p => p.Id);

            builder.Entity<Depoiment>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Depoiment>().Property(p => p.Text).IsRequired();
            builder.Entity<Depoiment>().Property(p => p.PersonName).IsRequired();

        }
    }
}