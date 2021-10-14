using DylanRoberts_Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanRoberts_Command.Invokers
{
    class Invoker 
    {
        ICommand command;

        public Invoker(ICommand command)
        {
            this.command = command;
        }

        public void Execute()
        {
            this.command.Execute();
        }

        public void Undo()
        {
            this.command.Undo();
        }
    }
}
