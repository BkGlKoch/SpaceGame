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

        public KeyEventArgs LastPressedKey { get; set; }

        public void Move()
        {
            //Nur wenn es eine zuletzt gedrückte Taste gibt
            // null => Es ist KEIN Objekt vorhanden
            if (LastPressedKey != null)
                switch (this.LastPressedKey.Key)
                {
                    case Key.W:
                        Pos.Y -= 10;
                        break;
                    case Key.A:
                        Pos.X -= 10;
                        break;
                    case Key.S;
                        Pos.Y += 10;
                        break;
                    case Key.D;
                        Pos.X += 10;
                        break;
                }
        }
        // Führt alle Draw Methoden aus
        public void draw()
        {
            draw_ship()
            draw_asteorid()
            draw_item()
            draw_projectile()
        }
        // Draw Methoden
        public void draw_ship()
        {
            // unser shape braucht, farbe, größe, form
            Shape.Fill = Brushes.Red;
            Point Shippoint1 = new Point(50, 10);
            Point Shippoint2 = new Point(0, 20);
            Point Shippoint3 = new Point(10, 10);
            Point Shippoint4 = new Point(0, 0);

            PointCollection myPointCollection_Shippoint = new PointCollection();
            myPointCollection_Shippoint.Add(Shippoint1);
            myPointCollection_Shippoint.Add(Shippoint2);
            myPointCollection_Shippoint.Add(Shippoint3);
            myPointCollection_Shippoint.Add(Shippoint4);
            Shape.Points = myPointCollection_Shippoint;
        }
        public void draw_asteorid()
        {
            Shape.Fill = Brushes.Grey;
            Point asteroidpoint1 = new Point (10, 0);
            Point asteroidpoint2 = new Point (20, 0);
            Point asteroidpoint3 = new Point (15, 20);

            PointCollection myPointCollection_asteroidpoint = new PointCollection();
            myPointCollection_asteroidpoint.Add(asteroidpoint1);
            myPointCollection_asteroidpoint.Add(asteroidpoint2);
            myPointCollection_asteroidpoint.Add(asteroidpoint3);
            Shape.Points = myPointCollection_asteroidpoint;
        }
        public void draw_item()
        {
            Shape.Fill = Brushes.Yellow;
            Point itempoint1 = new Point (0, 0);
            Point itempoint2 = new Point (20, 0);
            Point itempoint3 = new Point (0, 20);
            Point itempoint4 = new Point (20, 20)

            PointCollection myPointCollection_itempoint = new PointCollection();
            myPointCollection_itempoint.Add(itempoint1);
            myPointCollection_itempoint.Add(itempoint2);
            myPointCollection_itempoint.Add(itempoint3);
            myPointCollection_itempoint.Add(itempoint4);
            Shape.Points = myPointCollection_itempoint;
        }
        public void draw_projectile()
        {
            Shape.Fill = Brushes.OrangeRed;
            Point projectile1 = new Point (0, 0);
            Point projectile2 = new Point (5, 0);

            PointCollection myPointCollection_projectile = new PointCollection();
            myPointCollection_projectile.Add(projectile1);
            myPointCollection_projectile.Add(projectile2);
            Shape.Points = myPointCollection_projectile;
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