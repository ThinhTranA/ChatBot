
using Chat.Bot.Core;
using Xunit;

namespace UnitTests.AutomatedMessagingTests
{
    public class PublishShould
    {
        [Fact]
        public void AddAutomatedMessageToManagedMessages()
        {
            var messagingSystem = new AutomatedMessagingSystem();
            var intervalTriggeredMessage = new IntervalTriggeredMessage
            {
                DelayInMinutes = 1,
                Message = "Welcome! If you are enjoying the content, please follow for more!"
            };

            messagingSystem.Publish(intervalTriggeredMessage);

            Assert.Contains(intervalTriggeredMessage, messagingSystem.ManageMessages);

        }
    }
}
