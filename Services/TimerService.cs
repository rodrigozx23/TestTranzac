using time_of_your_life.Entity;
using time_of_your_life.Repositories;

namespace time_of_your_life.Services
{
    public class TimerService
    {
        private readonly TimerRepository _timerRepository;

        public TimerService(TimerRepository timerRepository)
        {
            _timerRepository = timerRepository ?? throw new ArgumentNullException(nameof(timerRepository));
        }

        public async Task AddTimer(TimerEntity timerEntity)
        {
            await _timerRepository.AddTimerAsync(timerEntity);
        }
    }
}
