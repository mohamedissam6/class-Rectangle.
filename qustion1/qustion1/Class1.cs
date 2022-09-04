using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qustion1
{
    internal class Rectangle
    {
        private float length;
        private float width;
       
        public Rectangle() { length = 1.0f; width = 1.0f; }
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public float Length {
            set {
                if ((value>0.0) && (value < 20.0))
                    length = value; 
            }
        get {
                return length; 
            }
        }
        public float Width
        {
            get 
            {
                return width; 
             }
            set
            {
                if ((value > 0.0) && (value < 20.0))
                {
                    width = value;
                }
            }
        }

        public float Perimeter()
        {
            return((2 * (length + width)));
       }
        public float Area()
        {
           return((length * width));
        }
    }
}
