using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Windows.Input;
//using.System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using Vector = System.Windows.Vector;

namespace Weltraum_Shooter_HIT13_22_23
{
    public class SpaceObject
    {

        public Vector Pos = new Vector();
        public Polygon Shape = new Polygon();

        //public int X { get; set; }
        //public int Y { get; set; }
        ////public Vector Pos { get => pos; set => pos = value; }
        ////private Vector pos = new Vector();

        //Polygon Shape = new Polygon();

        public void draw()
        {
            // unser shape braucht, farbe, größe, form
            Shape.Fill = Brushes.Red;
            Point Point1 = new Point(50, 10);
            Point Point2 = new Point(0, 20);
            Point Point3 = new Point(10, 10);
            Point Point4 = new Point(0, 0);

            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);

            Shape.Points = myPointCollection;


        }

        public void shown(Canvas SpaceCanvas)
        {
            // Unser SHape will angezeigt werden.
            Canvas.SetLeft(Shape, 0);
            Canvas.SetTop(Shape, 0);

            SpaceCanvas.Children.Add(Shape);
        }

    }
}