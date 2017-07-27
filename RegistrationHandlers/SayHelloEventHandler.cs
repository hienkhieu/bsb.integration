using System;
using System.Threading.Tasks;

namespace bsb.integration.RegistrationEventHandlers
{
    public class SayHelloEventHandler : IRegistrationModule
    {
        public void Visit(RegistrationEvents events)
        {
            //events.OrderSummited += args => Console.WriteLine($"Hello {args.PlayerName}. You are the best player in the world");

            events.OrderSummited +=
                async args => await Task.Run(
                    () => Console.WriteLine(
                        $"Hello {args.PlayerName}. You are the best player in the world"));
        }
    }
}