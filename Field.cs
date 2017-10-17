using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyton
{
    class Field
    {
        private delegate void FieldDel(int w,int h);
        private int width;
        private int height;
        private bool isGenerate = false;
        void AppleGenerator(ref List<BlockOfSnake> snake)
        {
            if (isGenerate)
            {
                for (int i = 0; i < snake.Count; i++)
                {
                    if ()
                    {

                    }
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
        void SetRect(int w, int h)
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
