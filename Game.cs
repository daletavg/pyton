﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyton
{
    class Game
    {
        Snake snake;
        Field field;
        DrawGame draw;
        Game()
        {
            field = new Field(20,20);
            snake = new Snake(5,5,field.Widht,field.Height);
            snake.SnakeUpdater
        }

    }
}
