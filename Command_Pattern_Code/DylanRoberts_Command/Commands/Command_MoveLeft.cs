using DylanRoberts_Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanRoberts_Command.Commands
{
    class Command_MoveLeft : ICommand
    {

        IReceiver device;

        public Command_MoveLeft( IReceiver device)
        {
            this.device = device;
        }

        public void Execute()
        {
            this.device.Move_Left();

        }

        public void Undo()
        {
            this.device.Move_Right();
        }
    }
}
