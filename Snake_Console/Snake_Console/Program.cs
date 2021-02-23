using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_Console
{
    class Program
    {
        public void game_draw()
        {
            Console.Clear();
            Console.Title = "Snake";
            Console.SetWindowSize(80, 25);

            Walls walls = new Walls(80,25);
            walls.draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.draw();
            foodcreator foodCreator = new foodcreator(80, 25, '¤');
            Point food = foodCreator.CREATEFOOD();
            food.Draw();
            while (true)
            {
                if (walls.IsHit(snake) || snake.ishittail())
                {
                    break;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo KEY = Console.ReadKey();
                    snake.handlekey(KEY.Key);
                }
                if (snake.eat(food))
                {
                    food = foodCreator.CREATEFOOD();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

            }
            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            START start = new START();
            if (start.choise()== 1)
            {
                Program prog = new Program();
                prog.game_draw();
            }
            else
            {
                start.Game_stop();
            }
        }
    }
}
