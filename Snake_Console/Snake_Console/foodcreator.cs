using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class foodcreator
    {
        int Mapwidth;
        int Mapheight;
        char sym;
        Random random = new Random();

        public foodcreator(int Mapwidth, int Mapheight, char sym)
        {
            this.Mapwidth = Mapwidth;
            this.Mapheight = Mapheight;
            this.sym = sym;
        }
        public Point CREATEFOOD()
        {
            int x = random.Next(2, Mapwidth - 2);
            int y = random.Next(2, Mapheight - 2);
            return new Point(x, y, sym);
        }
    }
}
