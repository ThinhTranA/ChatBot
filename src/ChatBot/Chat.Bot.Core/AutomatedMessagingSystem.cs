﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Chat.Bot.Core
{
    public class AutomatedMessagingSystem
    {
        public List<IAutomatedMessage> ManagedMessages { get; set; } = new List<IAutomatedMessage>(); //TODO: Lock down access to this 
        public List<string> QueuedMessages { get; set; } = new List<string>(); //TODO: lock down access to this

        public void Publish(IAutomatedMessage automatedMessage)
        {
            automatedMessage.Initialize(DateTime.Now);
            ManagedMessages.Add(automatedMessage);
        }

        public void CheckMessages(DateTime currentTime)
        {
            var messagesToQueue = ManagedMessages.Where(m => m.IsItYourTimeToDisplay(currentTime)).Select(m => m.GetMessageInstance
            (currentTime));

            QueuedMessages.AddRange(messagesToQueue);
        }

        public bool DequeueMessage(out string message)
        {
            message = default;
            if (!QueuedMessages.Any()) return false;

            message = QueuedMessages.First();
            QueuedMessages.RemoveAt(0);

            return true;
        }

    }
}