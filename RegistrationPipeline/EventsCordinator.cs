using bsb.integration.RegistrationEventHandlers;

namespace bsb.integration.RegistrationPipeline
{
    public class EventsCordinator
    {
        public EventsCordinator(RegistrationEvents events, RegistrationEventHandlersAgregation eventHandlersAgrregator)
        {
            this.Events = events;
            //var registrationModule = new SayHelloEventHandler();
            //registrationModule.Visit(Events);
            foreach (var handler in eventHandlersAgrregator.EventHandlers)
            {
                handler.Visit(Events);
            }
        }

        public RegistrationEvents Events { get; set; }  
    }
}