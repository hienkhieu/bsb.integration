using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using bsb.integration.RegistrationEventHandlers;

namespace bsb.integration.RegistrationPipeline
{
    public class RegistrationEventHandlersAgregation
    {

        public readonly IList<IRegistrationModule> EventHandlers = new List<IRegistrationModule>();

        public RegistrationEventHandlersAgregation()
        {
            // var all = Assembly
            //     .GetEntryAssembly()
            //     .GetReferencedAssemblies()
            //     .Select(Assembly.Load)
            //     .SelectMany(x => x.DefinedTypes)
            //     .Where(type => typeof(IRegistrationModule).IsAssignableFrom(type.AsType()));
            //
            // foreach (var ti in all)
            // {
            //     var t = ti.AsType();
            //     // eliminate interface itself
            //     if (t != typeof(IRegistrationModule))
            //     {
            //         // do work
            //         EventHandlers.Add(Activator.CreateInstance(t) as IRegistrationModule);
            //     }
            // }
            
            Assembly
                .GetEntryAssembly()
                .GetReferencedAssemblies()
                .Select(Assembly.Load)
                .SelectMany(x => x.DefinedTypes)
                .Where(type => typeof(IRegistrationModule).IsAssignableFrom(type.AsType()))
                .Select(ti => ti.AsType())
                .Where(x => x != typeof(IRegistrationModule))
                .ToList()
                .ForEach(x => EventHandlers.Add(Activator.CreateInstance(x) as IRegistrationModule));
        }
    }
}