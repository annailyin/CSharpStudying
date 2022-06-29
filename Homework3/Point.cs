﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpStudyingApp
{
    public class Point
    {
        private readonly decimal _x, _y;

        public decimal X
        {
            get { return _x; }
        }

        public decimal Y
        {
            get { return _y; }
        }

        public Point()
        {
            _x = 0.0m;
            _y = 0.0m;
        }

        public Point (decimal x, decimal y)
        {
            _x = x;
            _y = y;
        }

        //Copy constructor
        public Point(Point point)
        {
            _x = point.X;
            _y = point.Y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public override string ToString()
        {
            return $"x = {_x}, y = {_y}";
        }
    }
}
