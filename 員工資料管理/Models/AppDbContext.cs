using Microsoft.EntityFrameworkCore; 

namespace 員工資料管理.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet<員工資料模型> 員工資料 {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
