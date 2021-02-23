using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class figure
    {
        protected List<Point> plist;

        public virtual void draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
        internal bool IsHit(figure figure)
        {
            foreach (var p in plist)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (var p in plist)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
