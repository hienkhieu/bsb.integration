using System.ComponentModel;

namespace RegistrationPipeline
{
    public class OrderEventArgs: CancelEventArgs
    {
        public string PlayerName { get; private set; }

        public OrderEventArgs(string playerName)
        {
            this.PlayerName = playerName;
        }
    }
}