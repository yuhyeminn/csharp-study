﻿namespace Study_23_DataTable_DataSet
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
            this.btnReg = new System.Windows.Forms.Button();
            this.cboxRegClass = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tboxRegRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxRegName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoRegSexFemale = new System.Windows.Forms.RadioButton();
            this.rdoRegSexMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnViewDataDel = new System.Windows.Forms.Button();
            this.dgViewInfo = new System.Windows.Forms.DataGridView();
            this.cboxViewClass = new System.Windows.Forms.ComboBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(234, 176);
            this.btnReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(86, 29);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "등록";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // cboxRegClass
            // 
            this.cboxRegClass.FormattingEnabled = true;
            this.cboxRegClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반"});
            this.cboxRegClass.Location = new System.Drawing.Point(83, 4);
            this.cboxRegClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxRegClass.Name = "cboxRegClass";
            this.cboxRegClass.Size = new System.Drawing.Size(98, 23);
            this.cboxRegClass.TabIndex = 1;
            this.cboxRegClass.Text = "1반";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(333, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록하기";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tboxRegRef, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxRegClass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tboxRegName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tboxRegRef
            // 
            this.tboxRegRef.Location = new System.Drawing.Point(83, 112);
            this.tboxRegRef.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxRegRef.Name = "tboxRegRef";
            this.tboxRegRef.Size = new System.Drawing.Size(225, 25);
            this.tboxRegRef.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "반 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "이름 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "성별 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "특기 : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tboxRegName
            // 
            this.tboxRegName.Location = new System.Drawing.Point(83, 40);
            this.tboxRegName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxRegName.Name = "tboxRegName";
            this.tboxRegName.Size = new System.Drawing.Size(98, 25);
            this.tboxRegName.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoRegSexFemale);
            this.panel1.Controls.Add(this.rdoRegSexMale);
            this.panel1.Location = new System.Drawing.Point(80, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 35);
            this.panel1.TabIndex = 7;
            // 
            // rdoRegSexFemale
            // 
            this.rdoRegSexFemale.AutoSize = true;
            this.rdoRegSexFemale.Location = new System.Drawing.Point(88, 8);
            this.rdoRegSexFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoRegSexFemale.Name = "rdoRegSexFemale";
            this.rdoRegSexFemale.Size = new System.Drawing.Size(58, 19);
            this.rdoRegSexFemale.TabIndex = 1;
            this.rdoRegSexFemale.TabStop = true;
            this.rdoRegSexFemale.Text = "여자";
            this.rdoRegSexFemale.UseVisualStyleBackColor = true;
            // 
            // rdoRegSexMale
            // 
            this.rdoRegSexMale.AutoSize = true;
            this.rdoRegSexMale.Location = new System.Drawing.Point(3, 8);
            this.rdoRegSexMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoRegSexMale.Name = "rdoRegSexMale";
            this.rdoRegSexMale.Size = new System.Drawing.Size(58, 19);
            this.rdoRegSexMale.TabIndex = 0;
            this.rdoRegSexMale.TabStop = true;
            this.rdoRegSexMale.Text = "남자";
            this.rdoRegSexMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViewDataDel);
            this.groupBox2.Controls.Add(this.dgViewInfo);
            this.groupBox2.Controls.Add(this.cboxViewClass);
            this.groupBox2.Location = new System.Drawing.Point(14, 239);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(653, 245);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내용 확인";
            // 
            // btnViewDataDel
            // 
            this.btnViewDataDel.Location = new System.Drawing.Point(560, 22);
            this.btnViewDataDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewDataDel.Name = "btnViewDataDel";
            this.btnViewDataDel.Size = new System.Drawing.Size(86, 29);
            this.btnViewDataDel.TabIndex = 1;
            this.btnViewDataDel.Text = "삭제";
            this.btnViewDataDel.UseVisualStyleBackColor = true;
            this.btnViewDataDel.Click += new System.EventHandler(this.btnViewDataDel_Click);
            // 
            // dgViewInfo
            // 
            this.dgViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewInfo.Location = new System.Drawing.Point(7, 58);
            this.dgViewInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgViewInfo.Name = "dgViewInfo";
            this.dgViewInfo.RowTemplate.Height = 23;
            this.dgViewInfo.Size = new System.Drawing.Size(639, 180);
            this.dgViewInfo.TabIndex = 3;
            // 
            // cboxViewClass
            // 
            this.cboxViewClass.FormattingEnabled = true;
            this.cboxViewClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반"});
            this.cboxViewClass.Location = new System.Drawing.Point(7, 25);
            this.cboxViewClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxViewClass.Name = "cboxViewClass";
            this.cboxViewClass.Size = new System.Drawing.Size(98, 23);
            this.cboxViewClass.TabIndex = 2;
            this.cboxViewClass.SelectedIndexChanged += new System.EventHandler(this.cboxViewClass_SelectedIndexChanged);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(353, 191);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(86, 29);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 499);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ComboBox cboxRegClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tboxRegRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxRegName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoRegSexFemale;
        private System.Windows.Forms.RadioButton rdoRegSexMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgViewInfo;
        private System.Windows.Forms.ComboBox cboxViewClass;
        private System.Windows.Forms.Button btnViewDataDel;
        private System.Windows.Forms.Button btnModify;
    }
}

