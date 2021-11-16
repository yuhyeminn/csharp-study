﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_27_ThreadStop
{
    public partial class Form1 : Form
    {
        private enum enumPlayer
        {
            아이린,
            슬기,
            웬디,
            조이,
            예리,
        }

        int _locationX = 0;
        int _locationY = 0;

        List<Play> lplay = new List<Play>();

        public Form1()
        {
            InitializeComponent();

            _locationX = this.Location.X;
            _locationY = this.Location.Y;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Play oPlayForm in lplay)
            {
                oPlayForm.ThreadAbort(); // 프로그램 종료 시점이라서 강제로 Thread Stop 
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;

            for (int i = 0; i < numPlayerCount.Value; i++)
            {
                Play pl = new Play(((enumPlayer)i).ToString());
                pl.Location = new Point(_locationX, _locationY + pl.Height * i);
                pl.eventdelMessage += Pl_eventdelMessage;

                pl.Show();

                pl.fThreadStart();

                lplay.Add(pl);
            }
        }

        private int Pl_eventdelMessage(object sender, string strResult)
        {
            if (this.InvokeRequired) // 요청한 Thread가 현재 Main Thread에 있는 Conrol을 액세스 할 수 있는지 확인
            {
                this.Invoke(new Action(delegate ()
                {
                    Play oPlayerForm = sender as Play;

                    lboxResult.Items.Add(string.Format("Player : {0}, Text : {1}", oPlayerForm.StrPlayerName, strResult));
                }));
            }
            return 0;
        }
    }
}
