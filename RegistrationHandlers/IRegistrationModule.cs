namespace bsb.integration.RegistrationEventHandlers
{
    public interface IRegistrationModule
    {
        void Visit(RegistrationEvents events);
    }
}
