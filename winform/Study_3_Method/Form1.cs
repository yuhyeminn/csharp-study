using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_3_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNumber1.Text);
            int iNumB = int.Parse(tboxNumber2.Text);

            //int iResult = iNumA + iNumB;
            //tboxResult.Text = iResult.ToString();

            tboxResult.Text = fPlus(iNumA, iNumB).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNumber1.Text);
            int iNumB = int.Parse(tboxNumber2.Text);

            //int iResult = iNumA - iNumB;
            //tboxResult.Text = iResult.ToString();
            tboxResult.Text = fMinus(iNumA, iNumB).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNumber1.Text);
            int iNumB = int.Parse(tboxNumber2.Text);

            //int iResult = iNumA * iNumB;
            //tboxResult.Text = iResult.ToString();

            tboxResult.Text = fMulti(iNumA, iNumB).ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNumber1.Text);
            int iNumB = int.Parse(tboxNumber2.Text);

            //int iResult = iNumA / iNumB; //몫
            //// int iResultB = iNumA / iNumB // 나머지
            //tboxResult.Text = iResult.ToString();

            tboxResult.Text = fDivision(iNumA, iNumB).ToString();
        }


        private int fPlus(int iA, int iB)
        {
            int iResult = 0;

            iResult = iA + iB;

            return iResult;
        }

        private int fMinus(int iA, int iB)
        {
            int iResult = 0;

            iResult = iA - iB;

            return iResult;
        }

        private int fMulti(int iA, int iB)
        {
            int iResult = 0;

            iResult = iA * iB;

            return iResult;
        }

        private int fDivision(int iA, int iB)
        {
            int iResult = 0;

            iResult = iA / iB;

            return iResult;
        }
    }
}
