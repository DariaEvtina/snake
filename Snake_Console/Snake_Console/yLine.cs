using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class yLine : figure
    {

        public yLine(int y1, int yo, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = y1; y < yo; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);

            }
        }
    }
}