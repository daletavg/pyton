using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyton
{
    class BlockOfSnake
    {
        private int posX;
        private int posY;
        Direction direction;
        public Direction Dir
        {
            set
            {
                direction = value;
            }
            get
            {
                return direction;
            }
        }
        public int X
        {
            set
            {
                if (value < 0)
                {
                    posX = 0;
                    return;
                }
                posX = value;
            }
            get
            {
                return posX;
            }
        }
        public int Y
        {
            set
            {
                if (value < 0)
                {
                    posY = 0;
                    return;
                }
                posY = value;
            }
            get
            {
                return posY;
            }
        }
        private static int bordeWidth, borderHeight;
        public static void SetBorder(int width, int height)
        {
            bordeWidth = width;
            borderHeight = height;
        }
        public BlockOfSnake(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
