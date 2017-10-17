using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyton
{
    class DrawGame
    {
        char snakeNod = (char)2;
        char snakeBody = (char)3;
        char apple = (char)4;
        char field = '*';

        public void DrawSnake(ref List<BlockOfSnake> sn)
        {
            for (int i = 0; i < sn.Count; i++)
            {
                if (i==0)
                {
                    Console.CursorLeft= sn[i].X;
                    Console.CursorTop = sn[i].Y;
                    Console.Write(snakeNod);
                }
                else
                {
                    Console.CursorLeft = sn[i].X;
                    Console.CursorTop = sn[i].Y;
                    Console.Write(snakeBody);
                }
            }
        }
        public void DrawField(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (j==0)
                    {
                        Console.Write(field);
                    }
                    else if(i==0)
                    {
                        Console.Write(field);
                    }
                    else if (j == height-1)
                    {
                        Console.Write(field);
                    }
                    else if (i == width - 1)
                    {
                        Console.Write(field);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
