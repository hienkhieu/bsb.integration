using System;

namespace RegistrationPipeline
{
    public class RegistrationEvents
    {
        public Action<OrderEventArgs> OrderSource { get; set; }
    }
}