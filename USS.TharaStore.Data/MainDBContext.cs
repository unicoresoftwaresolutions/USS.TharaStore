using Microsoft.EntityFrameworkCore;
using USS.TharaStore.Model;

namespace USS.TharaStore.Data
{
    public class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options)
            : base(options)
        {

        }


    }
}
