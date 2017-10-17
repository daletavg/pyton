﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pyton
{
    enum Direction { UP, RIGHT, DOWN, LEFT };
    
    class Snake
    {
        private delegate void SnakeDel(ref List<BlockOfSnake> snake);
        List<BlockOfSnake> listOfSnake = new List<BlockOfSnake>();
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

        public Direction RIGHT { get; private set; }
        Snake(int posx,int posy,int pWidth,int pHeight)
        {
            BlockOfSnake.SetBorder(pWidth, pHeight);
            listOfSnake.Add(new BlockOfSnake(posx, posy));
            listOfSnake[0].Dir = RIGHT;
            Dir = RIGHT;
        }
        void SnakeUpdater(SnakeDel del)
        {
            del(ref listOfSnake);
        }

    }
}
