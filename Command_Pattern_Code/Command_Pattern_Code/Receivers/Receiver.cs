using Command_Pattern_Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Code.Receivers
{
    public class Receiver : IReceiver
    {
        public void TurnOff()
        {
            Console.WriteLine("Device is turned off");


        }

        public void TurnOn()
        {
            Console.WriteLine("Device is turned on");
        }
    }
}
