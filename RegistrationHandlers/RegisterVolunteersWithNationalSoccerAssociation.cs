using System;
using System.Linq;
using System.Threading.Tasks;

namespace bsb.integration.RegistrationEventHandlers
{
    public class RegisterVolunteersWithNationalSoccerAssociation: IRegistrationModule
    {
        public void Visit(RegistrationEvents events)
        {
            events.VolunteerRegistered += args =>
            {
                args.Volunteers.ToList().ForEach(x => Console.WriteLine(
                    $"Hello {x.Name}, we are submitting your information to National Soccer Association.\n Your position will be {x.VolunteerPosition}."));
                
                return Task.CompletedTask;
            };
        }
    }
}