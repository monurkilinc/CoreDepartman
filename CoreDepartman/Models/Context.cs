using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=corepersonel;Integrated Security=True;Trust Server Certificate=true;User Id=SA;Password={123456789};");
        }
            
        public DbSet<departmanlar> departmanlars { get; set; }
        public DbSet<personel> personels { get; set; }

    }
}
