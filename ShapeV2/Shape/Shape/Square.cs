using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Square : Rectangle
    {
        private double _len;

        public double len
        {
            get { return _len; }
            set { _len = value; }
        }

        public Square()
        {
            _len = 0;
        }

        public Square(double len)
        {
            _len = len;
        }

        public new double Area()
        {
            return _len * _len;
        }

        public new double Circumference()
        {
            return 4 * _len;
        }

    }
}
