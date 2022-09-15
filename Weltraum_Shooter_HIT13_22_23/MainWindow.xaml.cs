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

namespace Weltraum_Shooter_HIT13_22_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SpaceObject spaceShip = new SpaceObject();
            spaceShip.draw();
            spaceShip.shown(SpaceCanvas);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e, Key key)
        {

            //    SpaceObject spaceShip = new SpaceObject();
            //    if (e.Key == Key.D);
            //    spaceShip.Pos.X += 10;
            // BEI .XAML KeyDown="Window_KeyDown"
        }
    }
}
