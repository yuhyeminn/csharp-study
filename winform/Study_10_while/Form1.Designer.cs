﻿namespace Study_10_while
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblwhileResult = new System.Windows.Forms.Label();
            this.btnwhileResult = new System.Windows.Forms.Button();
            this.lboxwhileResult = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndowhileResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.lbldowhileResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblwhileResult
            // 
            this.lblwhileResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblwhileResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblwhileResult.Location = new System.Drawing.Point(17, 14);
            this.lblwhileResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwhileResult.Name = "lblwhileResult";
            this.lblwhileResult.Size = new System.Drawing.Size(324, 34);
            this.lblwhileResult.TabIndex = 0;
            this.lblwhileResult.Text = "0. 0. 0. 0. 0. 0.";
            this.lblwhileResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnwhileResult
            // 
            this.btnwhileResult.Location = new System.Drawing.Point(350, 14);
            this.btnwhileResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnwhileResult.Name = "btnwhileResult";
            this.btnwhileResult.Size = new System.Drawing.Size(107, 34);
            this.btnwhileResult.TabIndex = 1;
            this.btnwhileResult.Text = "로또 번호";
            this.btnwhileResult.UseVisualStyleBackColor = true;
            this.btnwhileResult.Click += new System.EventHandler(this.btnwhileResult_Click);
            // 
            // lboxwhileResult
            // 
            this.lboxwhileResult.FormattingEnabled = true;
            this.lboxwhileResult.ItemHeight = 18;
            this.lboxwhileResult.Location = new System.Drawing.Point(17, 52);
            this.lboxwhileResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboxwhileResult.Name = "lboxwhileResult";
            this.lboxwhileResult.Size = new System.Drawing.Size(323, 220);
            this.lboxwhileResult.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(17, 284);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 4);
            this.panel1.TabIndex = 3;
            // 
            // btndowhileResult
            // 
            this.btndowhileResult.Location = new System.Drawing.Point(113, 339);
            this.btndowhileResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndowhileResult.Name = "btndowhileResult";
            this.btndowhileResult.Size = new System.Drawing.Size(150, 34);
            this.btndowhileResult.TabIndex = 4;
            this.btndowhileResult.Text = "선택 번호 뽑기";
            this.btndowhileResult.UseVisualStyleBackColor = true;
            this.btndowhileResult.Click += new System.EventHandler(this.btndowhileResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "1~100 안의 숫자를 선택 하세요";
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(17, 342);
            this.tboxNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(81, 28);
            this.tboxNumber.TabIndex = 6;
            this.tboxNumber.Text = "1";
            // 
            // lbldowhileResult
            // 
            this.lbldowhileResult.AutoSize = true;
            this.lbldowhileResult.Location = new System.Drawing.Point(14, 398);
            this.lbldowhileResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldowhileResult.Name = "lbldowhileResult";
            this.lbldowhileResult.Size = new System.Drawing.Size(17, 18);
            this.lbldowhileResult.TabIndex = 7;
            this.lbldowhileResult.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 442);
            this.Controls.Add(this.lbldowhileResult);
            this.Controls.Add(this.tboxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndowhileResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxwhileResult);
            this.Controls.Add(this.btnwhileResult);
            this.Controls.Add(this.lblwhileResult);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwhileResult;
        private System.Windows.Forms.Button btnwhileResult;
        private System.Windows.Forms.ListBox lboxwhileResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndowhileResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Label lbldowhileResult;
    }
}

