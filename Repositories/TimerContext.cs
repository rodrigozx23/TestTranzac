using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using time_of_your_life.Entity;

namespace time_of_your_life.Repositories
{
    public class TimerContext : DbContext
    {
        public DbSet<TimerEntity> TimerEntity { get; set; }

        public TimerContext(DbContextOptions<TimerContext> options) : base(options)
        {

        }
    }
}
