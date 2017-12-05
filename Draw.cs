using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyton
{
    class Draw
    {
        
        public void DrawSnake(ICoord point)
        {
            if((point as SnakePoint).IsTail)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("*");
        }
        public void DrawPoly(ICoord point)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write("#");
        }
    }
}
