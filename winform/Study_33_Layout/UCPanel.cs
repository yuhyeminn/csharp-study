using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_33_Layout
{
    public partial class UCPanel : UserControl
    {
        public UCPanel()
        {
            InitializeComponent();
        }

        private void ucPanel_SizeChanged(object sender, EventArgs e)
        {
            lblPanel.Text = string.Format("({0}, {1})", lblPanel.Width, lblPanel.Height);
        }
    }
}
