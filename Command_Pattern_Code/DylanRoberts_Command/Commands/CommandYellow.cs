using DylanRoberts_Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanRoberts_Command.Commands
{
    class CommandYellow : ICommand
    {
        IReceiver device;

        public CommandYellow(IReceiver device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.device.Color_Yellow();
        }

        public void Undo()
        {
            this.device.Undo_Yellow();
        }
    }
}
