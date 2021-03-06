using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_13_Inheritance
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;
        CCycle _cC;
        CCar _cCar;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발자전거");
            _cC = new CCycle("자전거");
            _cCar = new CCar("자동차");
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fOneCycleDraw();
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCycleDraw();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCarDraw();
        }

        /// <summary>
        /// OneCycle 대한 위치 그림을 그려준다.
        /// </summary>
        private void fOneCycleDraw()
        {
            lblName.Text = _cOC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cOC.fPenInfo();

            g.DrawRectangle(p, _cOC._rtSquare);
            g.DrawEllipse(p, _cOC._rtCircle);
        }

        /// <summary>
        /// Cycle 대한 위치 그림을 그려준다.
        /// </summary>
        private void fCycleDraw()
        {
            lblName.Text = _cC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cC.fPenInfo();

            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);
        }

        /// <summary>
        /// Car 대한 위치 그림을 그려준다.
        /// </summary>
        private void fCarDraw()
        {
            lblName.Text = _cCar.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cCar.fPenInfo();

            g.DrawRectangle(p, _cCar._rtSquare1);
            g.DrawRectangle(p, _cCar._rtSquare2);
            g.DrawEllipse(p, _cCar._rtCircle1);
            g.DrawEllipse(p, _cCar._rtCircle2);
        }

        private void fClearPanel()
        {
            pMain.Invalidate();
            // 성능 관련하여 부하 걸릴 수 있으니 주의해서 사용할 것!
            Refresh();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            fClearPanel();

            switch(lblName.Text)
            {
                case "외발자전거":
                    _cOC.fMove(-5);
                    fOneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(-5);
                    fCycleDraw();
                    break;
                case "자동차":
                    _cCar.fMove(-5);
                    fCarDraw();
                    break;
            }
           
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발자전거":
                    _cOC.fMove(5);
                    fOneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(5);
                    fCycleDraw();
                    break;
                case "자동차":
                    _cCar.fMove(5);
                    fCarDraw();
                    break;
            }
        }
    }
}
