﻿namespace Study_34_LayoutEventControl
{
    partial class ucPanel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPanel
            // 
            this.lblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPanel.Location = new System.Drawing.Point(0, 0);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(144, 131);
            this.lblPanel.TabIndex = 0;
            this.lblPanel.Text = "(0, 0)";
            this.lblPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPanel.DoubleClick += new System.EventHandler(this.lblPanel_DoubleClick);
            // 
            // ucPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPanel);
            this.Name = "ucPanel";
            this.Size = new System.Drawing.Size(144, 131);
            this.SizeChanged += new System.EventHandler(this.Panel_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPanel;
    }
}
