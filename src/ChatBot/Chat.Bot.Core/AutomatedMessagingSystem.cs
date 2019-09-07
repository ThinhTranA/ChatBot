using System;
using System.Collections.Generic;

namespace Chat.Bot.Core
{
    public class AutomatedMessagingSystem
    {
        public List<AutomatedMessage> ManageMessages { get; set; } = new List<AutomatedMessage>();
        public List<string> QueuedMessages { get; set; } = new List<string>();

        public void Publish(AutomatedMessage automatedMessage)
        {
            ManageMessages.Add(automatedMessage);
        }
    }
}
