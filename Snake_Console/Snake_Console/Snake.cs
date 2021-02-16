using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class Snake : figure
    {
        public Snake(Point tail,int length,direction direct)
        {
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direct);
                plist.Add(p);
            }
        }
    }
}
