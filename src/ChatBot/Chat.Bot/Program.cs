using Chat.Bot.Core;
using System;
using System.Threading;


namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing the Bot...");
            Console.WriteLine("To exit, press [Ctrl]+C...");
            var automatedMessagingSystem = new AutomatedMessagingSystem();
            automatedMessagingSystem.Publish(new IntervalTriggeredMessage { DelayInMinutes = 1, Message = "Hello, everyone! I am the bot!" });
           

            while (true)
            {
                Thread.Sleep(1000);
                automatedMessagingSystem.CheckMessages(DateTime.Now);
             
                while(automatedMessagingSystem.DequeueMessage(out string theMessage))
                {
                    Console.WriteLine($"{DateTime.Now.ToShortTimeString()} - {theMessage}");
                }
            }
        }
    }
}
