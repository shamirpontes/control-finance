using ControlFinance.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControlFinance.Infra.Configuration {
    public class ContextBase : IdentityDbContext<ApplicationUser> {
        public ContextBase(DbContextOptions options) : base(options) {

        }

        public DbSet<SystemFinance> SystemFinance { set; get; }

        public DbSet<SystemFinanceUser> SystemFinanceUser { set; get; }

        public DbSet<Category> Category { set; get; }

        public DbSet<Expense> Expense { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            // Verifica se o DbContext já foi configurado
            if (!optionsBuilder.IsConfigured) 
            {
                // Configura o DbContext para usar o SQL Server com a string de conexão obtida
                optionsBuilder.UseSqlServer(RetrieveConnectionString());

                // Chama o método OnConfiguring da classe base
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }

        public string RetrieveConnectionString() {
            return "Data Source=NBQSP-FC693;Initial Catalog=FINANCEIRO_2023;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        }
    }
}
