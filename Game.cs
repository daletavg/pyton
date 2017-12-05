using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pyton
{
    enum Position { UP,DOWN,LEFT,RIGHT}
    class Game
    {
        Poly poly = new Poly();
        Draw draw = new Draw();
        Position dir = Position.RIGHT;

       

        Snake snake;
        public bool IsPlay { set; get; }
        public Game()
        {
            IsPlay = true;
            snake = new Snake(10, 10);
            snake._draw += draw.DrawSnake;
            Update();
        }
        private void OnTimer(object sender, ElapsedEventArgs arg /* Предоставляет данные для события Elapsed */)
        {
            switch (dir)
            {
                case Position.LEFT:
                    snake.X--;
                    break;
                case Position.UP:
                    snake.Y--;
                    break;
                case Position.RIGHT:
                    snake.X++;
                    break;
                case Position.DOWN:
                    snake.Y++;
                    break;
                default:
                    break;
            }
            snake.Draw();
        }
        void Update()
        {
            Timer t = new Timer();
            t.Interval = 100;
            // public event ElapsedEventHandler Elapsed - это событие происходит по истечении интервала времени
            t.Elapsed += new ElapsedEventHandler(OnTimer);
            t.Start();
            while (IsPlay)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        dir = Position.LEFT;
                        break;
                    case ConsoleKey.UpArrow:
                        dir = Position.UP;
                        break;
                    case ConsoleKey.RightArrow:
                        dir = Position.RIGHT;
                        break;
                    case ConsoleKey.DownArrow:
                        dir = Position.DOWN;
                        break;
                    default:
                        break;
                }
                
            }
        }
        

    }
}
