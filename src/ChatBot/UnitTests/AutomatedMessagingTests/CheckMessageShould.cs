﻿using Chat.Bot.Core;
using System;
using UnitTests.Fakes;
using Xunit;

namespace UnitTests.AutomatedMessagingTests
{
    public class CheckMessageShould
    {
        [Fact]
        public void AddNoMessagesToQueue_GivenNoAutomatedMessages()
        {
            var automatedMessagingSystem = new AutomatedMessagingSystem();
            automatedMessagingSystem.CheckMessages(DateTime.Now);
            Assert.Empty(automatedMessagingSystem.QueuedMessages);
        }

        [Fact]
        public void AddOneMessagesToQueue_GivenOneReadyAutomatedMessage()
        {
            var automatedMessagingSystem = new AutomatedMessagingSystem();
            automatedMessagingSystem.Publish(new AlwaysReadyMessage());

            automatedMessagingSystem.CheckMessages(DateTime.Now);
            Assert.Single(automatedMessagingSystem.QueuedMessages);
        }

        [Fact]
        public void AddOneMessagesToQueue_GivenManyMessages_OnlyOneReady()
        {
            var automatedMessagingSystem = new AutomatedMessagingSystem();
            automatedMessagingSystem.Publish(new NeverReadyMessage());
            automatedMessagingSystem.Publish(new AlwaysReadyMessage());
            automatedMessagingSystem.Publish(new NeverReadyMessage());

            automatedMessagingSystem.CheckMessages(DateTime.Now);
            Assert.Single(automatedMessagingSystem.QueuedMessages);
        }
    }
}
