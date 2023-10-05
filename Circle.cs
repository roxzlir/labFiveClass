using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labFiveClass
{
    internal class Circle
    {
        int _radius;
        double _pi;
        public Circle(int radius)
        {
            _radius = radius;
            _pi = Math.PI;
        }

        public void GetArea()
        {

            Console.WriteLine(_radius * _radius * _pi);
        }
    }
}
