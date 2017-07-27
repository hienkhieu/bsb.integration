using System;
using System.Threading.Tasks;

namespace bsb.integration.RegistrationEventHandlers
{
    public class RegisterPlayerWithNationalSoccerAssociation: IRegistrationModule
    {
        public void Visit(RegistrationEvents events)
        {
            //events.OrderSummited += args => Console.WriteLine($"{args.PlayerName}, you are now registered with National Soccer Association");

            events.OrderSummited +=
                async args => await Task.Run(
                    () => Console.WriteLine(
                        $"{args.PlayerName}, you are now registered with National Soccer Association"));
        }
    }
}