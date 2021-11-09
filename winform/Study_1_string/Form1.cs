using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = lblText.Text;
            lblContains.Text = str.Contains("Text").ToString();
            lblEquals.Text = str.Equals("Text").ToString();
            lblLength.Text = str.Length.ToString();
            lblReplace.Text = str.Replace("Text", "I Can").ToString();

            string[] strSplit = str.Split(',');
            lblSplit1.Text = strSplit[0].ToString();
            lblSplit2.Text = strSplit[1].ToString();
            lblSplit3.Text = strSplit[2].ToString();

            lblSubstring.Text = str.Substring(3, 5).ToString();
            lblToLower.Text = str.ToLower();
            lblToUpper.Text = str.ToUpper();
            lblTrim.Text = str.Trim();
        }
    }
}
