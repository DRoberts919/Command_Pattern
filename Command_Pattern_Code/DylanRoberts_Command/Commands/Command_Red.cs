using DylanRoberts_Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace DylanRoberts_Command.Commands
{
    class Command_Red : ICommand
    {
        IReceiver device;

        public Command_Red(IReceiver device)
        {
            this.device = device;
            
        }
        public void Execute()
        {
            
            this.device.Color_Red();


        }

        public void Undo()
        {
            this.device.Undo_Red();
        }
    }
}
