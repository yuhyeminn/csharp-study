using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_15_Encapsulation_PartialClass
{
    public partial class Form1 : Form
    {
        cData _Data = new cData();
        /// <summary>
        /// 프로그램의 진입점 입니다.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));

            foreach(EnumItem oitem in ei)
            {
                cboxItem.Items.Add(oitem);
            }

            foreach(EnumRate oitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(oitem);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.fDataResult();

            _Data.StrItem = cboxItem.Text;
            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);
            _Data.ICount = (int)numCout.Value;

            if (!String.IsNullOrEmpty(_Data.StrErrorName))
            {
                tboxErrorMsg.Text = _Data.StrErrorName;
                return;
            }

            double dPrice = _Data.fitemPrice();
            lboxItem.Items.Add(_Data.fResult(dPrice));

            _Data.DTotalPrice = dPrice;
            tboxResult.Text = _Data.DTotalPrice.ToString() + "원";
        }
    }
}
