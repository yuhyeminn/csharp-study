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

        /// <summary>
        /// 외부에서 호출 가능하도록
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fCircleMove(iMove);
            fSquareMove(iMove);
        }

        /// <summary>
        /// 내부에서만 움직인다
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircleMove(int iMove)
        {
            Point oPoint = _rtCircle.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle.Location = oPoint;
        }

        protected void fSquareMove(int iMove)
        {
            Point oPoint = _rtSquare.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare.Location = oPoint;
        }

    }
}
