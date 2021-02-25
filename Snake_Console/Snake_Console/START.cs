using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    public class START
    {
        public ConsoleKeyInfo key;
        public START()
        { 

        }
        int valik = 0;
        
        public int choise()
        {
            Console.WriteLine("START GAME - S\nExit - Q");
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.S)
            {
                valik = 1;
            }
            else if (key.Key == ConsoleKey.Q)
            {
                valik = 2;
            }
                return valik;
        }

        public void Game_stop()
        {
            Console.Clear();
            Console.WriteLine("Exit");
            Console.ReadLine();

        }

    }
}
