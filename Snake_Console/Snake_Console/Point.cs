using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class Point:figure
    {
        public int x;
        public int y;
        public char sym;
        public Point(int _x, int y_, char sym_)
        {
            x = _x;
            y = y_;
            sym = sym_;
        }
        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direct)
        {
            if(direct==Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direct==Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direct==Direction.UP)
            {
                y = y - offset;
            }
            else
            {
                y = y + offset;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
