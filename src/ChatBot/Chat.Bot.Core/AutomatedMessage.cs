using System;

namespace Chat.Bot.Core
{
    public class IntervalTriggeredMessage
    {
        public int DelayInMinutes { get; set; }
        public string Message { get; set; }
    }
}
