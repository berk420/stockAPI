using Microsoft.EntityFrameworkCore;
using stockAPI.Model;
namespace stockAPI.Data
{
    public class ApiContext :DbContext
    {
        public DbSet<stockmodel> bilanco { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }

    } 
}
