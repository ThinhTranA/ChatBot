using System;

namespace Chat.Bot.Core
{
    public interface IAutomatedMessage
    {
        void Initialize(DateTime currentTime);
        bool IsItYourTimeToDisplay(DateTime currentTime);
        string GetMessageInstance(DateTime currentTime);

    }
}
