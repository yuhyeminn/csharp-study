using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_29_UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var oControl in pMain.Controls)
            {
                if (oControl is UCInfo)
                {
                    UCInfo oInfo = oControl as UCInfo;
                    oInfo.eventdelSender += OInfo_eventdelSender;
                }
            }
        }

        private int OInfo_eventdelSender(object Sender, string strText)
        {
            UCInfo oInfo = Sender as UCInfo;

            lboxList.Items.Add(string.Format("{0} ) {1}", oInfo.UserName, strText));

            return 0;
        }
    }
}
