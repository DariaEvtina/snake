using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_Console
{
    class Program
    {
        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
        static void WriteGameOver()
        {
            int xO = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(xO, yOffset++);
            WriteText("============================", xO, yOffset++);
            WriteText("И Г Р А    О К О Н Ч Е Н А", xO + 1, yOffset++);
            WriteText("============================", xO, yOffset++);
        }
        public void game_draw()
        {
            Console.Clear();
            Console.Title = "Snake";
            Console.SetWindowSize(80, 25);
            RecordsList nm = new RecordsList();
            nm.WriteName();
            Console.Clear();
            Walls walls = new Walls(80,25);
            walls.draw();
            Score score = new Score(0, 1);//score =0, level=1
            RecordsList s = new RecordsList();
            score.speed = 200;
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.draw();
            foodcreator foodCreator = new foodcreator(80, 25, '¤');
            Point food = foodCreator.CREATEFOOD();
            foodcreator foodCreator1 = new foodcreator(80, 25, '#');
            Point betterfood = foodCreator1.CREATEFOOD();
            food.Draw();
            score.ScoreWrite();
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
                    food = foodCreator.CREATEFOOD();
                    food.Draw();
                    score.plusScore();
                    s.strScoresPlus();
                    score.ScoreWrite();
                    if (score.ScoreUp())
                    {
                        score.speed -= 10;
                    }
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(score.speed);

            }
            WriteGameOver();
            RecordsList W = new RecordsList();
            W.WriteInRecords(nm,s);
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
