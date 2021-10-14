using Command_Pattern_Code.Interfaces;
using Command_Pattern_Code.Receivers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Command_Pattern_Code.Clients
{
    public class Client : IReceiver
    {

        public static IReceiver getClient()
        {
            return new Receiver();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
