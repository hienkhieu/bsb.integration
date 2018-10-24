using System;
using System.Threading.Tasks;

namespace bsb.integration.RegistrationEventHandlers
{
    public class RegistrationEvents
    {
        // public Action<OrderEventArgs> OrderSummited { get; set; }
        // public Action<VolunteerEventArgs> VolunteerRegistered { get; set; }

        public Func<OrderEventArgs, Task> OrderSubmitted { get; set; }
        public Func<VolunteerEventArgs, Task> VolunteerRegistered { get; set; }
    }
}