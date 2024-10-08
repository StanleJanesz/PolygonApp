using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonApp.Polygon
{
    internal class Point
    {
        int x;
        int y;
        RadioButton PointButton;
        public Point (int x, int y, RadioButton radioButton)
        {
            this.x = x;
            this.y = y;
            this.PointButton = radioButton;
            this.PointButton.Location = new System.Drawing.Point(x,y);
            
        }
    }
}
