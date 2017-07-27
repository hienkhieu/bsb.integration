using System;
using RegistrationPipeline;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new RegistrationEvents();
            var registrationModule = new SayHelloAction();
            registrationModule.Initialize(events);

            Console.WriteLine("Player registration");

            if (events.OrderSource != null)
            {
                events.OrderSource.Invoke(new OrderEventArgs("Hien Khieu"));
            }
            Console.ReadKey();

        }
    }
}