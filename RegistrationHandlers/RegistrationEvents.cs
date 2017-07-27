using System;

namespace bsb.integration.RegistrationEventHandlers
{
    public class RegistrationEvents
    {
        public Action<OrderEventArgs> OrderSummited { get; set; }
    }
}