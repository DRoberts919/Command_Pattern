using System;
using System.Collections.Generic;
using System.Drawing;
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

        void Color_Red();

        void Undo_Red();

        void Color_Blue();

        void Undo_Blue();


        void Color_Green();

        void Undo_Green();

        void Color_Yellow();

        void Undo_Yellow();



        
    }
}
