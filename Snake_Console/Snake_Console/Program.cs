﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            xLine lineUP = new xLine(0, 78, 0, '+');
            xLine lineDOWN = new xLine(0, 78, 24, '+');
            yLine lineyLEFT = new yLine(0, 24, 0, '+');
            yLine lineyRIGHT = new yLine(0, 24, 78, '+');
            lineUP.draw();
            lineDOWN.draw();
            lineyLEFT.draw();
            lineyRIGHT.draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.draw();
            foodcreator foodCreator = new foodcreator(80, 25, '¤');
            Point food = foodCreator.CREATEFOOD();
            food.Draw();
            while (true)
            {
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


        }
    }
}
