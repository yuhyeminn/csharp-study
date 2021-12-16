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
    public partial class ucPanel : UserControl
    {
        public event EventHandler eLabelDoubleClickHandler;

        public ucPanel()
        {
            InitializeComponent();
        }

        private void Panel_SizeChanged(object sender, EventArgs e)
        {
            lblPanel.Text = string.Format("({0}, {1})", this.Width, this.Height);
        }

        private void lblPanel_DoubleClick(object sender, EventArgs e)
        {
            eLabelDoubleClickHandler(this, e);
        }
    }
}
