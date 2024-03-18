using Microsoft.EntityFrameworkCore;
using stockAPI.Model;
namespace stockAPI.Data
{
    public class ApiContext :DbContext
    {
        public DbSet<stockmodel> stocks { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }

    }
}
