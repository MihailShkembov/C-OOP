using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace _0._1BoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Height = height;
            this.Width = width;
        }
        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                    Environment.Exit(-1);
                }
                else
                {
                    this.length = value;
                }
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                    Environment.Exit(-1);
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                    Environment.Exit(-1);
                }
                else
                {
                    this.height = value;
                }
            }
        }
        public double FindSurfaceArea()
        {
            double surfaceArea = 2 * (this.Length * this.Width + this.Length * this.Height + this.Height * this.Width);
            return surfaceArea;
        }
        public double FindLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (this.Length * this.Height + this.Width * this.Height);
            return lateralSurfaceArea;
        }
        public double FindVolume()
        {
            return this.Height * this.Width * this.Length;
        }

    }
}
