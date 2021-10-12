using Command_Pattern_Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Code.Commands
{
    public class CommandTurnOff : ICommand
    {
        IReceiver device;

        public CommandTurnOff(IReceiver device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.TurnOff();
        }

        public void Undo()
        {
            this.device.TurnOn();
        }
    }
}
