using System;

namespace bsb.integration.RegistrationEvents
{
    public class AllEvents
    {
        public Action<OrderEventArgs> OrderSummited { get; set; }
    }
}