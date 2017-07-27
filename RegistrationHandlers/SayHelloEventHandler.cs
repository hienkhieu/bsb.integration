using System;

namespace bsb.integration.RegistrationEventHandlers
{
    public class SayHelloEventHandler : IRegistrationModule
    {
        public void Visit(RegistrationEvents events)
        {
            events.OrderSummited += args => Console.WriteLine($"Hello {args.PlayerName}. You are the best player in the world");
        }
    }
}