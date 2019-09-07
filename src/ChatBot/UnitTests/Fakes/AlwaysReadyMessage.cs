using Chat.Bot.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Fakes
{
    public class AlwaysReadyMessage : IAutomatedMessage
    {
        public string GetMessageInstance(DateTime currentTime)
        {
            return "Always Ready";
        }

        public void Initialize(DateTime currentTime)
        {
            
        }

        public bool IsItYourTimeToDisplay(DateTime currentTime)
        {
            return true;
        }
    }

   
}
