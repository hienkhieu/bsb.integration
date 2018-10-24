using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using bsb.integration.RegistrationEventHandlers;
using bsb.integration.RegistrationPipeline;
using Microsoft.Extensions.DependencyInjection;

namespace Start
{
    class Program
    {
        //public static event EventHandler<OrderEventArgs> OrderSubmitting; 

        static void Main(string[] args)
        {
           

            var serviceProvider = new ServiceCollection()
                .AddSingleton<RegistrationEvents>()
                .AddSingleton<EventsCordinator>()
                .AddSingleton<RegistrationEventHandlersAgregation>();

            var provider = serviceProvider.BuildServiceProvider();

            var eventCordinator = provider.GetService<EventsCordinator>();
            eventCordinator.Events.OrderSubmitted?.Invoke(new OrderEventArgs("Hien Khieu"));


            var volunteers = new List<VolunteerInfo>
            {
                new VolunteerInfo("Hien Khieu", 45, "Head Coach"),
                new VolunteerInfo("Bao Ngoc", 39, "Logistic")
            };

            eventCordinator.Events.VolunteerRegistered?.Invoke(new VolunteerEventArgs(volunteers));

            //Console.ReadKey();

        }
    }
}