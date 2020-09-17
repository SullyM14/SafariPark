using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public abstract class Shapes
    {
        public abstract int CalculateArea(); 
    }

    public class Rectangle : Shapes
    {
        private int _width;
        private int _height;

        public override int CalculateArea()
        {
            return (_width * _height);
        }
    }

    //public class SkinnyRectangle : Rectangle { 
    //    public override int CalculateArea()
    //    {

    //    }
    
    //}


}
