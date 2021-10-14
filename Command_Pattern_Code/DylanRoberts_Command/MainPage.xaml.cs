using DylanRoberts_Command.Clients;
using DylanRoberts_Command.Commands;
using DylanRoberts_Command.Interfaces;
using DylanRoberts_Command.Invokers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DylanRoberts_Command
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Rectangle rec = new Rectangle();
        IReceiver receiver;
        ICommand move_Up_Command;
        Invoker move_Up;

        ICommand move_Down_Command;
        Invoker move_Down;

        ICommand move_left_Command;
        Invoker move_left;

        ICommand move_Right_Command;
        Invoker move_Right;

        ICommand change_Color_Red;
        Invoker color_Red;

        public MainPage()
        {
            this.InitializeComponent();
            GenerateBoard();
            receiver = Client.getClient(rec);
            move_Up_Command = new Command_MoveUp(receiver);
            move_Up = new Invoker(move_Up_Command);

            move_Down_Command = new Command_MoveDown(receiver);
            move_Down = new Invoker(move_Down_Command);

            move_left_Command = new Command_MoveLeft(receiver);
            move_left = new Invoker(move_left_Command);

            move_Right_Command = new Command_MoveRight(receiver);
            move_Right = new Invoker(move_Right_Command);

            change_Color_Red = new Command_Red(receiver);
            color_Red = new Invoker(change_Color_Red);


        }

        private void GenerateBoard()
        {
    

             rec.Name = "Rectangle";

             rec.Stroke = new SolidColorBrush(Colors.Black);
             rec.StrokeThickness = 3;

            rec.Fill =new SolidColorBrush(Colors.Beige);

            rec.Width = 50;
            rec.Height = 50;

            //Canvas.SetLeft(rec, 50);
            //Canvas.SetTop(rec, 50);


            gameBoard.Children.Add(rec);

            

        }
        

        private void Up_Button(object sender, RoutedEventArgs e)
        {
            move_Up.Execute();
        }

        private void Down_Button(object sender, RoutedEventArgs e)
        {
            move_Down.Execute();
        }

        private void Left_Button(object sender, RoutedEventArgs e)
        {
            move_left.Execute();

        }
        
        private void Right_Button(object sender, RoutedEventArgs e)
        {
            move_Right.Execute();
        }

        private void Red_Button(object sender, RoutedEventArgs e)
        {
            color_Red.Execute();
        }

        private void Blue_Button(object sender, RoutedEventArgs e)
        {

        }

        private void Yellow_Button(object sender, RoutedEventArgs e)
        {

        }

        private void Green_Button(object sender, RoutedEventArgs e)
        {

        }

        private void Undo_Button(object sender, RoutedEventArgs e)
        {

        }
    }
}
