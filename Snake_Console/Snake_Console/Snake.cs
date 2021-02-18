using System.Collections.Generic;
using System.Linq;

namespace Snake_Console
{
    class Snake : figure
    {
        direction _direction;
        public Snake(Point tail, int length, direction direct)
        {
            _direction = direct;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direct);
                plist.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = getnextpoint();
            plist.Add(head);
            tail.Clear();
            head.Draw();
        }
        public Point getnextpoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        //internal void Move()
        //{
            //throw new NotImplementedException();
        //}
    }
}
