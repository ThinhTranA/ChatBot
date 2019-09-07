using System;
using System.Collections.Generic;

namespace Chat.Bot.Core
{
    public class AutomatedMessagingSystem 
    {
        public List<IntervalTriggeredMessage> ManageMessages { get; set; } = new List<IntervalTriggeredMessage>();
        public List<string> QueuedMessages { get; set; } = new List<string>();

    

        public void Publish(IntervalTriggeredMessage automatedMessage)
        {
            ManageMessages.Add(automatedMessage);
        }
    }
}
