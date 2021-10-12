using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern_Code.Interfaces
{
    public interface ICommand
    {

        public void Execute();


        public void Undo();
        
    }
}
