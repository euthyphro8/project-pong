﻿using System;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using TittyPong.IO;

namespace TittyPong.Events
{
    public class EventManager
    {
        public event EventHandler<ClientListReceivedEventArgs> ClientListReceivedEvent;
        public event EventHandler<ConnectEventArgs> ConnectEvent;
        public event EventHandler<EventArgs> ConnectSuccessEvent;
        public event EventHandler<ByteArrayEventArgs> SendMessageEvent;
        public event EventHandler<ConnectionInfoEventArgs> ConnectionInfoEvent;
        public event EventHandler<StringEventArgs> StartGameRequestEvent;
        public event EventHandler<ReceivedStartGameRequestEventArgs> ReceivedStartGameRequestEvent;
        

        public void OnStartGameRequestEvent(object sender, StringEventArgs e)
        {
            StartGameRequestEvent?.Invoke(sender, e);
        }

        public void OnConnectionInfoEvent(object sender, ConnectionInfoEventArgs e)
        {
            ConnectionInfoEvent?.Invoke(sender, e);
        }
        
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

        public void OnClientListReceived(object sender,ClientListReceivedEventArgs e)
        {
            ClientListReceivedEvent?.Invoke(sender, e);
        }

        public void OnReceivedStartGameRequestEvent(object sender, ReceivedStartGameRequestEventArgs e)
        {
            ReceivedStartGameRequestEvent?.Invoke(sender, e);
        }
    }
}
