using DylanRoberts_Command.Interfaces;
using DylanRoberts_Command.Receiver; 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace DylanRoberts_Command.Clients
{
    class Client 
    {
        Rectangle rectangle;

        public IReceiver getClient(Rectangle rectangle)
        {
            return new Receiver.Receiver(rectangle);
        }

 
    }
}
