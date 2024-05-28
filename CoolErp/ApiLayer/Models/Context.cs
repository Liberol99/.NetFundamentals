using Microsoft.EntityFrameworkCore;

namespace ApiLayer.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2L7VMMU\SQLEXPRESS;Database=CoolErpOtherDb;Trusted_Connection=True;");
        }
        public DbSet<Accounting> Accountings { get; set; }
    }
}