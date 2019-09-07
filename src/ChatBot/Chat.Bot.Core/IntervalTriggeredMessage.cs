using System;

namespace Chat.Bot.Core
{
    public class IntervalTriggeredMessage : IAutomatedMessage
    {
        private DateTime _previousRunTimes;
        public int DelayInMinutes { get; set; }
        public string Message { get; set; }

        public void Initialize(DateTime currentTime)
        {
            _previousRunTimes = currentTime;
        }

        public bool IsItYourTimeToDisplay(DateTime currentTime)
        {
            if (_previousRunTimes.AddMinutes(DelayInMinutes) > currentTime)
                return false;

            return true;
        }
    }
}
