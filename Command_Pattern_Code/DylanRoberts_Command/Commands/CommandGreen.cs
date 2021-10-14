using DylanRoberts_Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanRoberts_Command.Commands
{
    public class CommandGreen : ICommand
    {
        IReceiver device;

        public CommandGreen(IReceiver device)
        {
            this.device = device;
        }


        public void Execute()
        {
            this.device.Color_Green();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
