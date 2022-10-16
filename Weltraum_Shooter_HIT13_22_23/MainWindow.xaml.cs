using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Weltraum_Shooter_HIT13_22_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpaceObject spaceShip = new SpaceObject(); // temporär
        Dispatchertimer timer = new Dispatchertimer();




        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += Animation;


        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SpaceObject spaceShip = new SpaceObject();
            spaceShip.draw();
            //spaceShip.Move();
            spaceShip.shown(SpaceCanvas);
            timer.start();

        }

        private void Animation(object sender, RoutedEventArgs e)
        {
            SpaceCanvas.Children.Clear();
            //spaceShip.draw();
            

            spaceShip.Move();
            spaceShip.shown(SpaceCanvas);

           spaceShip.LastPressedKey = e;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e, Key key)
        {
            spaceShip.LastPressedKey = e;

            //    SpaceObject spaceShip = new SpaceObject();
            //    if (e.Key == Key.D);
            //    spaceShip.Pos.X += 10;
            // BEI .XAML KeyDown="Window_KeyDown"
        }
    }
}
