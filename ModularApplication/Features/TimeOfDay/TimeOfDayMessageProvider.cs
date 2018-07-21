using OrchardCore.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModularApplication.Features.TimeOfDay
{
    public class TimeOfDayMessageProvider : IMessageProvider
    {
        private readonly IClock _clock;

        public TimeOfDayMessageProvider(IClock clock)
        {
            _clock = clock;
        }

        public Task<string> GetMessageAsync()
        {
            return Task.FromResult($"The current time is: {_clock.UtcNow.ToLocalTime().TimeOfDay}");
        }
    }
}
