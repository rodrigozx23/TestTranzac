using time_of_your_life.Repositories;
using time_of_your_life.Entity;

namespace time_of_your_life.Repositories
{
    public class TimerRepository
    {
        private readonly TimerContext _context;

        public TimerRepository(TimerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); ;
        }

        public async Task AddTimerAsync(TimerEntity timerEntity)
        {
            _context.TimerEntity.Add(timerEntity);
            await _context.SaveChangesAsync();
        }
    }
}
