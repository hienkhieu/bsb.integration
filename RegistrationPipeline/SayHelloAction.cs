using System;

namespace RegistrationPipeline
{
    public class SayHelloAction : IRegistrationModule
    {
        public void Initialize(RegistrationEvents events)
        {
            events.OrderSource += args => Console.WriteLine($"Hello {args.PlayerName}. You are the best player in the world");
        }
    }
}