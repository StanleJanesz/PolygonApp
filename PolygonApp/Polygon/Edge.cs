using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonApp.Polygon
{
    internal class Edge
    {
        Point point1;
        Point point2;
        public Edge ( Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
    }
}
