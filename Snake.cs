using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyton
{
    
   
    class Snake
    {
        public event DrawDlg _draw;
        private List<SnakePoint> _snake=new List<SnakePoint>();
        public int X
        {
            set
            {
                _snake[0].X=value;
            }
            get
            {
                return _snake[0].X;
            }
        }
        public int Y
        {
            set
            {
                _snake[0].Y = value;
            }
            get
            {
                return _snake[0].Y;
            }
        }
       


        public Snake()
        {
            AddSnakePoint(5, 5);
        }
        public Snake(int X, int Y)
        {
            AddSnakePoint(X, Y);
        }
        public void AddSnakePoint(int X, int Y)
        {
            SnakePoint tmp = new SnakePoint();
            tmp.X = X;
            tmp.Y = Y;
            tmp.PrevX = X;
            tmp.PrevY = Y;
            tmp.IsTail = true;
            _snake.Add(tmp);
        }
        void Update()
        {
            if (_snake.Count>1)
            {
                for (int i = 0; i < _snake.Count; i++)
                {
                    if (i+1>=_snake.Count)
                    {
                        break;
                    }
                    _snake[i + 1].X = _snake[i].PrevX;
                    _snake[i + 1].Y = _snake[i].PrevY;
                }
            }
        }
        public void Draw()
        {
            foreach (SnakePoint item in _snake)
            {
                _draw(item);
            }
        }

    }
}
