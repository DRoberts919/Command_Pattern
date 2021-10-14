using DylanRoberts_Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace DylanRoberts_Command.Receiver
{
    public class Receiver : IReceiver
    {
        Rectangle rectangle;

        public Receiver(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }


        public void Color_Blue()
        {
            this.rectangle.Fill = new SolidColorBrush(Colors.Blue);
        }

        public void Color_Green()
        {
            this.rectangle.Fill = new SolidColorBrush(Colors.Green);
        }

        public void Color_Red()
        {
            this.rectangle.Fill = new SolidColorBrush(Colors.Red);
        }

        public void Color_Yellow()
        {
            this.rectangle.Fill = new SolidColorBrush(Colors.Yellow);
        }

        public void Move_Down()
        {
            Canvas.SetTop(this.rectangle, 50);
        }

        public void Move_Left()
        {
            Canvas.SetLeft(this.rectangle, -50);
        }

        public void Move_Right()
        {
            Canvas.SetLeft(this.rectangle, 50);
        }

        public void Move_Up()
        {
            Canvas.SetTop(this.rectangle, -50);
        }


    }
}
