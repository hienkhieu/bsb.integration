using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace bsb.integration.RegistrationEventHandlers
{
    public class VolunteerEventArgs: CancelEventArgs
    {
        public IList<VolunteerInfo> Volunteers { get; }

        public VolunteerEventArgs(IList<VolunteerInfo> volunteers)
        {
            Volunteers = volunteers;
        }
    }

    public class VolunteerInfo
    {
        public VolunteerInfo(string name, int age, string position)
        {
            Name = name;
            Age = age;
            VolunteerPosition = position;
        }
        public string Name { get; }
        public int Age { get; }
        public string VolunteerPosition { get; }
    }
}