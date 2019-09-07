using Chat.Bot.Core;
using System;

namespace UnitTests.Fakes
{
    public class NeverReadyMessage : IAutomatedMessage
    {
        public string GetMessageInstance(DateTime currentTime)
        {
            throw new NotImplementedException("How did you do this!!??");
        }

        public void Initialize(DateTime currentTime)
        {
        }

        public bool IsItYourTimeToDisplay(DateTime currentTime)
        {
            return false;
        }
    }
}