namespace Study_19_ENC_DEC
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTickPoint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1Add = new System.Windows.Forms.Button();
            this.btn50Add = new System.Windows.Forms.Button();
            this.btn3Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblTickPoint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "점수";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTotal.Location = new System.Drawing.Point(10, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(357, 80);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTickPoint
            // 
            this.lblTickPoint.BackColor = System.Drawing.SystemColors.Window;
            this.lblTickPoint.Location = new System.Drawing.Point(106, 27);
            this.lblTickPoint.Name = "lblTickPoint";
            this.lblTickPoint.Size = new System.Drawing.Size(261, 18);
            this.lblTickPoint.TabIndex = 1;
            this.lblTickPoint.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tick Point:";
            // 
            // btn1Add
            // 
            this.btn1Add.Location = new System.Drawing.Point(13, 162);
            this.btn1Add.Name = "btn1Add";
            this.btn1Add.Size = new System.Drawing.Size(197, 27);
            this.btn1Add.TabIndex = 1;
            this.btn1Add.Text = "+1";
            this.btn1Add.UseVisualStyleBackColor = true;
            this.btn1Add.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn50Add
            // 
            this.btn50Add.Location = new System.Drawing.Point(12, 228);
            this.btn50Add.Name = "btn50Add";
            this.btn50Add.Size = new System.Drawing.Size(197, 27);
            this.btn50Add.TabIndex = 2;
            this.btn50Add.Text = "+50";
            this.btn50Add.UseVisualStyleBackColor = true;
            this.btn50Add.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn3Add
            // 
            this.btn3Add.Location = new System.Drawing.Point(13, 195);
            this.btn3Add.Name = "btn3Add";
            this.btn3Add.Size = new System.Drawing.Size(197, 27);
            this.btn3Add.TabIndex = 2;
            this.btn3Add.Text = "+3";
            this.btn3Add.UseVisualStyleBackColor = true;
            this.btn3Add.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "(100)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "(300)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "(5000)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 275);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn3Add);
            this.Controls.Add(this.btn50Add);
            this.Controls.Add(this.btn1Add);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += Form1_FormClosed;                   
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTickPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btn1Add;
        private System.Windows.Forms.Button btn50Add;
        private System.Windows.Forms.Button btn3Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

