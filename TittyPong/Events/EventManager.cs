﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TittyPong.IO;

namespace TittyPong.Events
{
    public class EventManager
    {
        public event EventHandler<ConnectEventArgs> ConnectEvent;
        public event EventHandler<EventArgs> ConnectSuccessEvent;
        public event EventHandler<ByteArrayEventArgs> SendMessageEvent;
        public event EventHandler<StringEventArgs> ConnectionInfoEvent;
        public void OnConnectionInfoEvent(object sender, StringEventArgs e)
        {
            ConnectionInfoEvent?.Invoke(sender, e);
        }

        public event EventHandler<ByteArrayEventArgs> SendMessageEvent;
        public void OnSendMessageEvent(object sender, ByteArrayEventArgs e)
        {
            SendMessageEvent?.Invoke(sender, e);
        }

        public void OnConnectEvent(object sender, ConnectEventArgs connectEventArgs)
        {
            ConnectEvent?.Invoke(sender, connectEventArgs);
        }

        public void OnConnectSuccessEvent(object sender)
        {
            ConnectSuccessEvent?.Invoke(sender, EventArgs.Empty);
        }
    }
}
