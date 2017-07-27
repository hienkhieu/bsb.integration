using System;

namespace bsb.integration.RegistrationEventHandlers
{
    public class RegistrationEvents
    {
        public Action<OrderEventArgs> OrderSummited { get; set; }
        public Action<VolunteerEventArgs> VolunteerRegistered { get; set; }

        //public Func<OrderEventArgs, Task> OrderSummited { get; set; }
        //public Func<VolunteerEventArgs, Task> VolunteerRegistered { get; set; }
    }
}