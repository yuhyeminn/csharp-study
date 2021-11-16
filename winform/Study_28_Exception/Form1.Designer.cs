namespace Study_28_Exception
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblColorinfo = new System.Windows.Forms.Label();
            this.tbarAlpha = new System.Windows.Forms.TrackBar();
            this.pColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColorDelete = new System.Windows.Forms.Button();
            this.btnColorSave = new System.Windows.Forms.Button();
            this.lboxColor = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblColorinfo);
            this.groupBox1.Controls.Add(this.tbarAlpha);
            this.groupBox1.Controls.Add(this.pColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Select";
            // 
            // lblColorinfo
            // 
            this.lblColorinfo.AutoSize = true;
            this.lblColorinfo.Location = new System.Drawing.Point(65, 92);
            this.lblColorinfo.Name = "lblColorinfo";
            this.lblColorinfo.Size = new System.Drawing.Size(15, 15);
            this.lblColorinfo.TabIndex = 5;
            this.lblColorinfo.Text = "-";
            // 
            // tbarAlpha
            // 
            this.tbarAlpha.Location = new System.Drawing.Point(60, 52);
            this.tbarAlpha.Maximum = 255;
            this.tbarAlpha.Name = "tbarAlpha";
            this.tbarAlpha.Size = new System.Drawing.Size(66, 56);
            this.tbarAlpha.TabIndex = 4;
            this.tbarAlpha.Value = 255;
            this.tbarAlpha.Scroll += new System.EventHandler(this.tbarAlpha_Scroll);
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(75, 29);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(20, 20);
            this.pColor.TabIndex = 3;
            this.pColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pColor_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alpha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color :";
            // 
            // btnColorDelete
            // 
            this.btnColorDelete.Location = new System.Drawing.Point(237, 144);
            this.btnColorDelete.Name = "btnColorDelete";
            this.btnColorDelete.Size = new System.Drawing.Size(95, 28);
            this.btnColorDelete.TabIndex = 1;
            this.btnColorDelete.Text = "삭제";
            this.btnColorDelete.UseVisualStyleBackColor = true;
            this.btnColorDelete.Click += new System.EventHandler(this.btnColorDelete_Click);
            // 
            // btnColorSave
            // 
            this.btnColorSave.Location = new System.Drawing.Point(135, 144);
            this.btnColorSave.Name = "btnColorSave";
            this.btnColorSave.Size = new System.Drawing.Size(95, 28);
            this.btnColorSave.TabIndex = 2;
            this.btnColorSave.Text = "저장";
            this.btnColorSave.UseVisualStyleBackColor = true;
            this.btnColorSave.Click += new System.EventHandler(this.btnColorSave_Click);
            // 
            // lboxColor
            // 
            this.lboxColor.FormattingEnabled = true;
            this.lboxColor.ItemHeight = 15;
            this.lboxColor.Location = new System.Drawing.Point(12, 180);
            this.lboxColor.Name = "lboxColor";
            this.lboxColor.Size = new System.Drawing.Size(320, 184);
            this.lboxColor.TabIndex = 3;
            this.lboxColor.SelectedIndexChanged += new System.EventHandler(this.lboxColor_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Study_28_Exception.Properties.Resources.Back;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(338, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 343);
            this.panel1.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(166, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(105, 115);
            this.panel7.TabIndex = 3;
            this.panel7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(8, 109);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(50, 173);
            this.panel8.TabIndex = 0;
            this.panel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(51, 197);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(104, 101);
            this.panel6.TabIndex = 2;
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(20, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 75);
            this.panel4.TabIndex = 1;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(130, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 142);
            this.panel5.TabIndex = 0;
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(35, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 96);
            this.panel3.TabIndex = 0;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxColor);
            this.Controls.Add(this.btnColorSave);
            this.Controls.Add(this.btnColorDelete);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblColorinfo;
        private System.Windows.Forms.TrackBar tbarAlpha;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColorDelete;
        private System.Windows.Forms.Button btnColorSave;
        private System.Windows.Forms.ListBox lboxColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
    }
}

