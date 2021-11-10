using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Study_13_Inheritance
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle; // 바퀴
        public Rectangle _rtSquare; // 몸통

        public COneCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);

            _rtCircle = new Rectangle(120, 150, 120, 120);
            _rtSquare = new Rectangle(150, 30, 60, 120);
        }

        public Pen fPenInfo()
        {
            return _Pen;
        }
    }
}
