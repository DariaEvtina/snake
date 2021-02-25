using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class Walls
    {
        List<figure> wallist;
        public Walls(int w,int h)
        {
            wallist = new List<figure>();
            xLine lineUP = new xLine(0, w-2, 0, '+');
            xLine lineDOWN = new xLine(0, w-2, h-1, '+');
            yLine lineyLEFT = new yLine(0, h-1, 0, '+');
            yLine lineyRIGHT = new yLine(0, h-1, w-2, '+');
            wallist.Add(lineUP);
            wallist.Add(lineDOWN);
            wallist.Add(lineyLEFT);
            wallist.Add(lineyRIGHT);
            
        }
        internal bool IsHit(figure figure)
        {
            foreach (var wall in wallist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void draw()
        {
            foreach (var wall in wallist)
            {
                wall.draw();
            }
        }
    }
}
