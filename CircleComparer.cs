using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableShape
{
    public class CircleComparator : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.getRadius() > c2.getRadius()) return 1;
            else if (c1.getRadius() < c2.getRadius()) return -1;
            else return 0;
        }
        public int Compare(Rectangle r1, Rectangle r2)
        {
            if (r1.getWidth() > r2.getWidth()) return 1;
            else if (r1.getWidth() < r2.getWidth()) return -1;
            else return 0;

            if (r1.getLength() > r2.getLength()) return 1;
            else if (r1.getLength() < r2.getLength()) return -1;
            else return 0;
        }
    }
}
