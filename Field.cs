using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyton
{
    struct Apples
    {
        public int X { set; get; }
        public int Y { set; get; }
    }
    class Field
    {

        private delegate void FieldDel(int w,int h);
        private int width;
        private int height;
        private bool isGenerate = false;
        private Apples apple;
        public Apples Apple
        {
            get
            {
                return apple;
            }
        }

        public Field(int w, int h)
        {
            SetRect(w, h);
        }
        public void AppleGenerator(ref List<BlockOfSnake> snake)
        {
            if (isGenerate)
            {
                Random rnd = new Random();
                bool isSnake = false;
                Apples ap = new Apples();
                ap.X = rnd.Next(1, width - 1);
                ap.Y = rnd.Next(1, height - 1);
                for (int i = 0; i < snake.Count; i++)
                {
                    if (ap.X==snake[i].X&& ap.Y == snake[i].Y)
                    {
                        isSnake = true;
                        break;
                    }
                }
                if (!isSnake)
                {
                    isGenerate = false;
                    apple = ap;
                }
            }
        }
        public int Widht
        {
            set
            {
                if (value<11)
                {
                    throw new Exception("Width is small");
                }
                width = value;
            }
            get
            {
                return width;
            }
        }
        public int Height
        {
            set
            {
                if(value < 11)
                {
                    throw new Exception("Height is small");
                }
                height = value;
            }
            get
            {
                return height;
            }
        }
        public void SetRect(int w, int h)
        {
            Widht = w;
            Height = h;
        }

        void Draw(FieldDel del)
        {
            del(Widht,Height);
        }
    }
}
