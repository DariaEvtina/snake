using System;
using System.Collections.Generic;
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
        string name;
        public int choise()
        {
            Console.WriteLine("==================================\n ENTER YOURE NICKNAME OR USERNAME \n==================================");
            name = Console.ReadLine();
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
            {

            }
        }
    }
}
