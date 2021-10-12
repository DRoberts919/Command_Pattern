using Command_Pattern_Code.Interfaces;
using Command_Pattern_Code.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Code.Clients
{
    public class Client
    {

        public static IReceiver getClient()
        {
            return new Receiver();
        }

    }
}
