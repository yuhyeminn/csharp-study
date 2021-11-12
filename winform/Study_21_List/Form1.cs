using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_21_List
{
    public partial class Form1 : Form
    {
        List<string> _strList = new List<string>();
        List<int> _intList = new List<int>();
        ArrayList _arList = new ArrayList();

        public Form1()
        {
            InitializeComponent();

            dgViewList.Columns.Add("dgValue", "Value"); // 컬럼 추가
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pbox1":
                    strSelectText = "cake";
                    break;
                case "pbox2":
                    strSelectText = "burger";
                    break;
                case "pbox3":
                    strSelectText = "pizza";
                    break;
                case "pbox4":
                    strSelectText = "ice";
                    break;
            }

            _strList.Add(strSelectText);

            fUIDisplay();
            fDataGridViewDisplay();
        }

        private void fUIDisplay()
        {
            int iCake = 0;
            int iBurger = 0;
            int iPizza = 0;
            int iIce = 0;

            foreach (var oitem in _strList)
            {
                switch (oitem)
                {
                    case "cake":
                        iCake++;
                        break;
                    case "burger":
                        iBurger++;
                        break;
                    case "pizza":
                        iPizza++;
                        break;
                    case "ice":
                        iIce++;
                        break;
                }
            }
            lblPick1.Text = iCake.ToString();
            lblPick2.Text = iBurger.ToString();
            lblPick3.Text = iPizza.ToString();
            lblPick4.Text = iIce.ToString();

            lblTotalCount.Text = _strList.Count.ToString();
        }

        private void fDataGridViewDisplay()
        {
            // 아래 4줄을 이 한줄로 끝낼 수 있음
            // 컬럼 추가 코드도 작성하지 않아도 됨
            //  dgViewList.DataSource = _strList.Select(x => new { Value = x}).ToList();

            dgViewList.Rows.Clear();

            foreach (string oitem in _strList)
            {
                dgViewList.Rows.Add(oitem);
            }

            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }

            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
