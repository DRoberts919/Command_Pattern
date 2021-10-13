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
        private Array[,] boardSetup;

        public MainPage()
        {
            this.InitializeComponent();
            GenerateBoard();
        }

        private void GenerateBoard()
        {
            
            
             Rectangle rec = new Rectangle();

             rec.Name = "Rectangle";

             rec.Stroke = new SolidColorBrush(Colors.Black);
             rec.StrokeThickness = 3;

            rec.Fill =new SolidColorBrush(Colors.Beige);

            rec.Width = 50;
            rec.Height = 50;

            Canvas.SetLeft(rec, 50);
            Canvas.SetTop(rec, 50);


            gameBoard.Children.Add(rec);
        }
        

        private void Up_Button()
        {

        }

        private void Down_Button()
        {

        }

        private void Left_Button()
        {

        }
        
        private void Right_Button()
        {

        }

        private void Red_Button()
        {

        }

        private void BlueButton()
        {

        }

        private void Yellow_Button()
        {

        }

        private void Green_Button()
        {

        }

        private void Undo_Button()
        {

        }
    }
}
