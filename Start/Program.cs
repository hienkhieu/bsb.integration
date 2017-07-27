using System;
using bsb.integration.RegistrationEventHandlers;
using bsb.integration.RegistrationPipeline;
using Microsoft.Extensions.DependencyInjection;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
                .AddSingleton<RegistrationEvents>()
                .AddSingleton<EventsCordinator>()
                .AddSingleton<RegistrationEventHandlersAgregation>();

            var provider = serviceProvider.BuildServiceProvider();

            var eventCordinator = provider.GetService<EventsCordinator>();

            Console.WriteLine("Submit order");

            eventCordinator.Events.OrderSummited?.Invoke(new OrderEventArgs("Hien Khieu"));
            //Console.ReadKey();

        }
    }
}