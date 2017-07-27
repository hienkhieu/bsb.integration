using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationPipeline
{
    interface IRegistrationModule
    {
        void Initialize(RegistrationEvents events);
    }
}
