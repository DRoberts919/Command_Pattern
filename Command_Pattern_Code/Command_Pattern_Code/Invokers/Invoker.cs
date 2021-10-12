using Command_Pattern_Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Code.Invokers
{
    public class Invoker
    {
        ICommand command;

        public Invoker(ICommand command)
        {
            this.command = command;
        }


        public void ExecuteCommand()
        {
           this.command.Execute();
        }

        public void UndoCommand()
        {
            this.command.Undo();
        }
    }
}
