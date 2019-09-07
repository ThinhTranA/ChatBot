using System;
using System.Collections.Generic;
using System.Linq;

namespace Chat.Bot.Core
{
    public class AutomatedMessagingSystem
    {
        public List<IAutomatedMessage> ManagedAutomatedMessages { get; set; } = new List<IAutomatedMessage>();
        public List<string> QueuedMessages { get; set; } = new List<string>();

        public void Publish(IAutomatedMessage automatedMessage)
        {
            ManagedAutomatedMessages.Add(automatedMessage);
        }

        public void CheckMessages(DateTime currentTime)
        {
            var messagesToQueue = ManagedAutomatedMessages.Where(m => m.IsItYourTimeToDisplay(currentTime)).Select(m => m.GetMessageInstance
            (currentTime));

            QueuedMessages.AddRange(messagesToQueue);
        }
    }
}