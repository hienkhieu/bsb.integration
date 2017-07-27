using System;
using System.Threading.Tasks;

namespace bsb.integration.RegistrationEventHandlers
{
    public class RegisterVolunteersWithNationalSoccerAssociation: IRegistrationModule
    {
        public void Visit(RegistrationEvents events)
        {
            events.VolunteerRegistered += async args =>
            {
                Console.WriteLine("Before sumitting voluteer");
                foreach (var volunteer in args.Volunteers)
                {
                    await Task.Run(() => Console.WriteLine(
                        $"Hello {volunteer.Name}, we are submitting your information to National Soccer Association.\n Your position will be {volunteer.VolunteerPosition}."));
                }
            };
        }
    }
}