using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_8_if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ifTest()
        {
            int ia = 30;
            int ib = 20;

            string strResult = string.Empty;

            if(ia > ib)
            {
                strResult = "ia가 크다!";
            }
            else if(ia < ib)
            {
                strResult = "ib가 크다!";
            }
            else
            {

            }

        }
    }
}
