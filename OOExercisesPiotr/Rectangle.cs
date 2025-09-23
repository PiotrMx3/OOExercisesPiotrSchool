using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Rectangle
    {
        private double _width;
        private double _height;

        public Rectangle()
        {
        
        }

      
        public Rectangle(double width, double height)
        {
            Width = width;   
            Height = height; 
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een breedte van {value} in te stellen!");
                }
                else
                {
                    _width = value;
                }
            }
        }


        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een hoogte van {value} in te stellen!");
                }
                else
                {
                    _height = value;
                }
            }
        }

     

        public double Area()
        {
            return Width * Height;
        }
    }
}
