using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyton
{
    delegate void DrawDlg(ICoord poit);
    class SnakePoint:ICoord
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int PrevX { set; get; }
        public int PrevY { set; get; }
        public bool IsTail { set; get; }
    }
}
