using Microsoft.EntityFrameworkCore;

namespace WebApi.DBContext
{
    public class HMSDBContext: DbContext
    {
        public HMSDBContext(DbContextOptions<HMSDBContext> options) : base(options)
        {

        }
        public DbSet<Entities.BaseUserEntity> Users { get; set; }
    }
}
