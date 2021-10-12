using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Code.Interfaces
{
    public interface IReceiver
    {

        public void TurnOn();

        public void TurnOff();
    }
}
