using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_34_LayoutEventControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ucCMenu.eColorSender += UcCMenu_eColorSender;
            ucCMenu.eColorAction += UcCMenu_eColorAction;

            ucPanelTop.eLabelDoubleClickHandler += UcPanelTop_eLabelDoubleClickHandler;
            ucPanelCenter1.eLabelDoubleClickHandler += UcPanelTop_eLabelDoubleClickHandler;
            ucPanelCenter2.eLabelDoubleClickHandler += UcPanelTop_eLabelDoubleClickHandler;
            ucPanelRight.eLabelDoubleClickHandler += UcPanelTop_eLabelDoubleClickHandler;
        }

        private void UcPanelTop_eLabelDoubleClickHandler(object sender, EventArgs e)
        {
            string strResult = ucCMenu.fButtonColorChange((ucPanel)sender);
            lboxLog.Items.Add(strResult);
        }

        private void UcCMenu_eColorAction(Button arg1, Color arg2)
        {
            string strPanelName = string.Empty;

            switch (arg1.Name)
            {
                case "btn1":
                    ucPanelTop.BackColor = arg2;
                    strPanelName = "Panel Top";
                    break;
                case "btn2":
                    ucPanelCenter1.BackColor = arg2;
                    strPanelName = "Panel Center1";
                    break;
                case "btn3":
                    ucPanelCenter2.BackColor = arg2;
                    strPanelName = "Panel Center2";
                    break;
                case "btn4":
                    ucPanelRight.BackColor = arg2;
                    strPanelName = "Panel Right";
                    break;
                default:
                    break;
            }

            string strResult = string.Format("선택 : {0}, {1}의 색상을 {2}로 변경", arg1.Name, strPanelName, arg2.ToString());
            lboxLog.Items.Add(strResult);
        }

        private void UcCMenu_eColorSender(object oSender, Color oColor)
        {

        }
    }
}
