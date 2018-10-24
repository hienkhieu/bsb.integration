using System;
using System.Threading.Tasks;

namespace bsb.integration.RegistrationEventHandlers
{
    public class RegisterPlayerWithNationalSoccerAssociation: IRegistrationModule
    {
        public void Visit(RegistrationEvents events)
        {
            events.OrderSubmitted += args =>
            {
                Console.WriteLine(
                    $"{args.PlayerName}, you are now registered with National Soccer Association");
                return Task.CompletedTask;
            };
        }
    }
}