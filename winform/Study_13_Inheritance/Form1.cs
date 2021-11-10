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
        /// <summary>
        /// 프로그램의 진입점 입니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            COneCycle cOC = new COneCycle("외발자전거");

            lblName.Text = cOC.strName;
             
            Graphics g = pMain.CreateGraphics();
            Pen p = cOC.fPenInfo();

            g.DrawRectangle(p, cOC._rtSquare);
            g.DrawEllipse(p, cOC._rtCircle);
            
        }
    }
}
