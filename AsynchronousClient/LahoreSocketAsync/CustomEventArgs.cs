using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LahoreSocketAsync
{
    public class ClientConnectedEventArgs : EventArgs
    {
        private string mNewClient;
        public string NewClient { get { return mNewClient; } }

        public ClientConnectedEventArgs(string _newClient)
        {
            mNewClient = _newClient;
        }
    }

    public class TextReceivedEventArgs : EventArgs
    {
        private string mClientWhoSentText;
        public string ClientWhoSentText { get { return mClientWhoSentText; } }

        private string mTextReceived;
        public string TextReceived { get { return mTextReceived; } }

        public TextReceivedEventArgs(string _clientWhoSentText, string _textReceived)
        {
            mClientWhoSentText = _clientWhoSentText;
            mTextReceived = _textReceived;
        }
    }
}