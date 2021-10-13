using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DylanRoberts_Command.Interfaces
{
    public interface IReceiver
    {

       void Move_Up();

        void Move_Down();

        void Move_Right();

        void Move_Left();
    }
}
