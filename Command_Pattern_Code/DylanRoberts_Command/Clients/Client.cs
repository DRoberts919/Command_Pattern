using DylanRoberts_Command.Interfaces;
using DylanRoberts_Command.Receiver; 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanRoberts_Command.Clients
{
    class Client
    {
        public static IReceiver GetClient()
        {
            return new Receiver.Receiver();
        }


    }
}
