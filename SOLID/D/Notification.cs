using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class Notification
    {
        private ICollection<IMessage> _messages;

        // ctor injection
        public Notification(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
