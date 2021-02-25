using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake_Console
{
    class Snake : figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
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
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void handlekey(ConsoleKey  KEY)
        {
            if (KEY == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (KEY == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (KEY == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (KEY == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }
        internal bool eat(Point food)
        {
            Point head = getnextpoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool eatBetterFood(Point food)
        {
            Point head = getnextpoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                plist.Add(food);
                plist.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool ishittail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count-2; i++)
            {
                if (head.IsHit(plist[i]))
                {
                    return true;
                }
            }
            return false;
        }
        //internal void Move()
        //{
            //throw new NotImplementedException();
        //}
    }
}
