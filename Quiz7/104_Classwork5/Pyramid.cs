﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Quiz6;

namespace _106_Quiz6
{
    class Pyramid: Shape3D
    {
        new private static int _amount;
        //private double _density;
        private double _side;
        private double _height;
        public Pyramid(): base()
        {
            //_density = 0;
            _side = 0;
            _height = 0;
            _amount++;
        }
        public Pyramid(double side, double height,double density): base(density)
        {
            //Density = density;
            Side = side;
            Height = height;
            _amount++;
        }
       new public static int Amount
        {
            get { return _amount; }
        }
        public double Side
        {
            get { return _side; }
            set
            {
                if (value < 0)
                    _side = 0;
                else
                    _side = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                    _height = 0;
                else
                    _height = value;
            }
        }
        //public double Density
        //{
        //    get { return _density; }
        //    set
        //    {
        //        if (value < 0)
        //            _density = 0;
        //        else
        //            _density = value;
        //    }
        //}
        public override double Volume()
        {
            return 1.0/3*_side*_side*_height;
        }
        //public double Weight()
        //{
        //    return _density * Volume();
        //}
        public override string ShapeProperty()
        {
            string str = string.Format("{0,8}", "Pyramid");
            str += '\t';
            str += string.Format("{0,8:F2}", _side);
            str += '\t';
            str += string.Format("{0,8:F2}", _height);
            str += '\t';
            //str += string.Format("{0,8:F2}", _density);
            //str += '\t';
            //str += string.Format("{0,8:F2}", Volume());
            //str += '\t';
            //str += string.Format("{0,8:F2}", Weight());
            str += Property();
            return str;
        }
    }
}
