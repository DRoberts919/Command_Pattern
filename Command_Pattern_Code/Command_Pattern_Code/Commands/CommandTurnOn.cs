using Command_Pattern_Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Code.Commands
{
    class CommandTurnOn : ICommand
    {
        IReceiver device;

        public CommandTurnOn(IReceiver device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.TurnOn();
        }

        public void Undo()
        {
            this.device.TurnOff();
        }
    }
}
