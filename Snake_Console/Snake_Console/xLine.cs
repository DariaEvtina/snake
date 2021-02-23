using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class xLine : figure
    {

        public xLine(int xleft, int xright, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xleft; x < xright; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);

            }
        }
        public override void draw()
        {
            base.draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
