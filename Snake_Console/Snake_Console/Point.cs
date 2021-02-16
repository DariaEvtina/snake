using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point(int _x,int y_,char sym_)
        {
            Console.WriteLine("LOADING...");
            x = _x;
            y = y_;
            sym = sym_;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
