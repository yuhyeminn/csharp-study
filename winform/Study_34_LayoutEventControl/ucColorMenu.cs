using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_34_LayoutEventControl
{
    public partial class ucColorMenu : UserControl
    {
        // 메인 폼으로 이벤트 넘기는 방법
        // 1) Delegate Event 선언
        public delegate void delColorSender(object oSender, Color oColor);
        public event delColorSender eColorSender;

        // 2) 기본 EventHandler
        public event EventHandler oColorEventHandler;

        // 3) 제네릭 형태의 delegate 사용
        public event Action<Button, Color> eColorAction;

        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult dRet = cd.ShowDialog();

            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = cd.Color;
            }
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                Button obtn = new Button();

                obtn.Name = "btn" + i;
                obtn.Text = string.Format("P{0} 색상 변경", i);
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 20, 0, 0);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;

                flipMenu.Controls.Add(obtn);
            }
        }

        private void Obtn_Click(object sender, EventArgs e)
        {
            // 1)
            // eColorSender(sender, pColor.BackColor);

            // 2)
            // oColorEventHandler(sender, e);

            // 3)
            eColorAction((Button)sender, pColor.BackColor);
        }

        public string fButtonColorChange(ucPanel oPanel)
        {
            string strResult = string.Empty;
            string strbtnName = string.Empty;
            switch (oPanel.Name)
            {
                case "ucPanelTop":
                    strbtnName = "btn1";
                    break;
                case "ucPanelCenter1":
                    strbtnName = "btn2";
                    break;
                case "ucPanelCenter2":
                    strbtnName = "btn3";
                    break;
                case "ucPanelRight":
                    strbtnName = "btn4";
                    break;
                default:
                    break;
            }

            strResult = fBtnSearch(strbtnName, oPanel.BackColor, oPanel.Name);
            return strResult;
        }

        private string fBtnSearch(string strButtonName, Color oColor, string strPanelName)
        {
            string strResult = string.Empty;

            foreach (var oitem in flipMenu.Controls)
            {
                if (oitem is Button)
                {
                    Button obtn = oitem as Button;

                    if (obtn.Name.Equals(strButtonName))
                    {
                        obtn.BackColor = oColor;
                        strResult = string.Format("{0} Panel DoubleClick. {1}의 색상을 {2}로 변경", strPanelName, strButtonName, oColor.ToString());
                        return strResult;
                    }
                }
            }

            return null;
        }
    }
}
