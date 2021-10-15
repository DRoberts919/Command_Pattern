using DylanRoberts_Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanRoberts_Command.Commands
{
    class CommandBlue : ICommand
    {
        IReceiver device;

        public CommandBlue(IReceiver device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.Color_Blue();
        }

        public void Undo()
        {
            this.device.Undo_Blue();
        }
    }
}
