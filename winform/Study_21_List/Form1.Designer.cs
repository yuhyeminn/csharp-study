﻿namespace Study_21_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPick4 = new System.Windows.Forms.Label();
            this.lblPick3 = new System.Windows.Forms.Label();
            this.lblPick2 = new System.Windows.Forms.Label();
            this.pbox4 = new System.Windows.Forms.PictureBox();
            this.pbox3 = new System.Windows.Forms.PictureBox();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.lblPick1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgViewList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "※ 선호하는 항목을 선택해 주세요.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblPick4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPick1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 144);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblPick4
            // 
            this.lblPick4.AutoSize = true;
            this.lblPick4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPick4.Location = new System.Drawing.Point(318, 119);
            this.lblPick4.Name = "lblPick4";
            this.lblPick4.Size = new System.Drawing.Size(101, 25);
            this.lblPick4.TabIndex = 7;
            this.lblPick4.Text = "0";
            this.lblPick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick3
            // 
            this.lblPick3.AutoSize = true;
            this.lblPick3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPick3.Location = new System.Drawing.Point(213, 119);
            this.lblPick3.Name = "lblPick3";
            this.lblPick3.Size = new System.Drawing.Size(99, 25);
            this.lblPick3.TabIndex = 6;
            this.lblPick3.Text = "0";
            this.lblPick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick2
            // 
            this.lblPick2.AutoSize = true;
            this.lblPick2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPick2.Location = new System.Drawing.Point(108, 119);
            this.lblPick2.Name = "lblPick2";
            this.lblPick2.Size = new System.Drawing.Size(99, 25);
            this.lblPick2.TabIndex = 5;
            this.lblPick2.Text = "0";
            this.lblPick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbox4
            // 
            this.pbox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox4.Image = global::Study_21_List.Properties.Resources._4;
            this.pbox4.Location = new System.Drawing.Point(318, 3);
            this.pbox4.Name = "pbox4";
            this.pbox4.Size = new System.Drawing.Size(101, 113);
            this.pbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox4.TabIndex = 3;
            this.pbox4.TabStop = false;
            this.pbox4.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox3
            // 
            this.pbox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox3.Image = global::Study_21_List.Properties.Resources._3;
            this.pbox3.Location = new System.Drawing.Point(213, 3);
            this.pbox3.Name = "pbox3";
            this.pbox3.Size = new System.Drawing.Size(99, 113);
            this.pbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox3.TabIndex = 2;
            this.pbox3.TabStop = false;
            this.pbox3.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox2
            // 
            this.pbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox2.Image = global::Study_21_List.Properties.Resources._2;
            this.pbox2.Location = new System.Drawing.Point(108, 3);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(99, 113);
            this.pbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox2.TabIndex = 1;
            this.pbox2.TabStop = false;
            this.pbox2.Click += new System.EventHandler(this.pbox_Click);
            // 
            // pbox1
            // 
            this.pbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox1.Image = global::Study_21_List.Properties.Resources._1;
            this.pbox1.Location = new System.Drawing.Point(3, 3);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(99, 113);
            this.pbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox1.TabIndex = 0;
            this.pbox1.TabStop = false;
            this.pbox1.Click += new System.EventHandler(this.pbox_Click);
            // 
            // lblPick1
            // 
            this.lblPick1.AutoSize = true;
            this.lblPick1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPick1.Location = new System.Drawing.Point(3, 119);
            this.lblPick1.Name = "lblPick1";
            this.lblPick1.Size = new System.Drawing.Size(99, 25);
            this.lblPick1.TabIndex = 4;
            this.lblPick1.Text = "0";
            this.lblPick1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "TotalCount : ";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(119, 197);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(18, 18);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "※ List의 Data를 화면에 보여줍니다.";
            // 
            // dgViewList
            // 
            this.dgViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewList.Location = new System.Drawing.Point(102, 266);
            this.dgViewList.Name = "dgViewList";
            this.dgViewList.RowTemplate.Height = 30;
            this.dgViewList.Size = new System.Drawing.Size(240, 185);
            this.dgViewList.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 463);
            this.Controls.Add(this.dgViewList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgViewList;
        private System.Windows.Forms.PictureBox pbox4;
        private System.Windows.Forms.PictureBox pbox3;
        private System.Windows.Forms.PictureBox pbox2;
        private System.Windows.Forms.Label lblPick4;
        private System.Windows.Forms.Label lblPick3;
        private System.Windows.Forms.Label lblPick2;
        private System.Windows.Forms.Label lblPick1;
    }
}

