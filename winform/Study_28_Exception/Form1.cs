using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_28_Exception
{
    public partial class Form1 : Form
    {
        Dictionary<string, Color> dColor = new Dictionary<string, Color>();
        Color oSelectColor = new Color();

        public Form1()
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
            lblColorinfo.Text = pColor.BackColor.ToString();
        }

        private void tbarAlpha_Scroll(object sender, EventArgs e)
        {
            pColor.BackColor = Color.FromArgb(tbarAlpha.Value, pColor.BackColor);
            lblColorinfo.Text = pColor.BackColor.ToString();
        }

        private void btnColorSave_Click(object sender, EventArgs e)
        {
            try
            {
                Color oColor = pColor.BackColor;
                dColor.Add(oColor.ToString(), oColor);

                LBoxRefresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LBoxRefresh()
        {
            try
            {
                lboxColor.Items.Clear();

                foreach (string okey in dColor.Keys)
                {
                    lboxColor.Items.Add(okey);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnColorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lboxColor.SelectedItem != null && dColor.ContainsKey(lboxColor.SelectedItem.ToString()))
                {
                    dColor.Remove(lboxColor.SelectedItem.ToString());

                }
                else
                {
                    MessageBox.Show("삭제할 item이 없거나 키가 없습니다");
                }

                LBoxRefresh();
            }
            catch (NullReferenceException ex)
            {
                ex.ToString();
            }
        }

        private void lboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            oSelectColor = dColor[lboxColor.SelectedItem.ToString()];
        }

        private void Panel_Click(object sender, MouseEventArgs e)
        {
            try
            {
                Panel oPanel = sender as Panel;
                oPanel.BackColor = oSelectColor;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
