using DylanRoberts_Command.Clients;
using DylanRoberts_Command.Commands;
using DylanRoberts_Command.Interfaces;
using DylanRoberts_Command.Invokers;
using System;
using System.Collections.Generic;
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

        Stack<Invoker> invokers = new Stack<Invoker>();

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

        ICommand change_Color_Blue;
        Invoker color_Blue;

        ICommand change_Color_Green;
        Invoker color_Green;

        ICommand Change_Color_Yellow;
        Invoker color_Yellow;

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

            change_Color_Blue = new CommandBlue(receiver);
            color_Blue = new Invoker(change_Color_Blue);

            change_Color_Green = new CommandGreen(receiver);
            color_Green = new Invoker(change_Color_Green);

            Change_Color_Yellow = new CommandYellow(receiver);
            color_Yellow = new Invoker(Change_Color_Yellow);

        }

        private void GenerateBoard()
        {

             rec.Name = "Rectangle";

             rec.Stroke = new SolidColorBrush(Colors.Black);
             rec.StrokeThickness = 3;

            rec.Fill =new SolidColorBrush(Colors.Red);

            rec.Width = 50;
            rec.Height = 50;

            gameBoard.Children.Add(rec);
        }
        

        private void Up_Button(object sender, RoutedEventArgs e)
        {
            move_Up.Execute();


            invokers.Push(move_Up);
        }

        private void Down_Button(object sender, RoutedEventArgs e)
        {
            move_Down.Execute();
            invokers.Push(move_Down);
        }

        private void Left_Button(object sender, RoutedEventArgs e)
        {
            move_left.Execute();

            invokers.Push(move_left);

        }
        
        private void Right_Button(object sender, RoutedEventArgs e)
        {
            move_Right.Execute();

            invokers.Push(move_Right);
        }

        private void Red_Button(object sender, RoutedEventArgs e)
        {
            color_Red.Execute();
            invokers.Push(color_Red);
        }

        private void Blue_Button(object sender, RoutedEventArgs e)
        {
            color_Blue.Execute();
            invokers.Push(color_Blue);

        }

        private void Yellow_Button(object sender, RoutedEventArgs e)
        {
            color_Yellow.Execute();
            invokers.Push(color_Yellow);

        }

        private void Green_Button(object sender, RoutedEventArgs e)
        {
            color_Green.Execute();
            invokers.Push(color_Green);

        }

        private void Undo_Button(object sender, RoutedEventArgs e)
        {
            try
            {

            invokers.Peek().Undo();
            invokers.Pop();
            }
            catch
            {
                rec.Fill = new SolidColorBrush(Colors.Red);
                Console.WriteLine("You cant undo now");
            }
        }
    }
}
