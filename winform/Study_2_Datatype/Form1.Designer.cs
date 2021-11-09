namespace Study_2_Datatype
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
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.BtnEx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.BtnShort = new System.Windows.Forms.Button();
            this.BtnInt = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(34, 31);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(420, 28);
            this.tboxNumber.TabIndex = 0;
            // 
            // BtnEx
            // 
            this.BtnEx.Location = new System.Drawing.Point(461, 31);
            this.BtnEx.Name = "BtnEx";
            this.BtnEx.Size = new System.Drawing.Size(122, 28);
            this.BtnEx.TabIndex = 1;
            this.BtnEx.Text = "알아서 변환";
            this.BtnEx.UseVisualStyleBackColor = true;
            this.BtnEx.Click += new System.EventHandler(this.BtnEx_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exception";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(164, 84);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(18, 18);
            this.lblShort.TabIndex = 6;
            this.lblShort.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(164, 136);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(18, 18);
            this.lblInt.TabIndex = 7;
            this.lblInt.Text = "0";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(164, 181);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(18, 18);
            this.lblDouble.TabIndex = 8;
            this.lblDouble.Text = "0";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(164, 240);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(17, 18);
            this.lblException.TabIndex = 9;
            this.lblException.Text = "-";
            // 
            // BtnShort
            // 
            this.BtnShort.Location = new System.Drawing.Point(268, 78);
            this.BtnShort.Name = "BtnShort";
            this.BtnShort.Size = new System.Drawing.Size(113, 31);
            this.BtnShort.TabIndex = 10;
            this.BtnShort.Text = "Short 변환";
            this.BtnShort.UseVisualStyleBackColor = true;
            this.BtnShort.Click += new System.EventHandler(this.BtnShort_Click);
            // 
            // BtnInt
            // 
            this.BtnInt.Location = new System.Drawing.Point(268, 129);
            this.BtnInt.Name = "BtnInt";
            this.BtnInt.Size = new System.Drawing.Size(113, 31);
            this.BtnInt.TabIndex = 11;
            this.BtnInt.Text = "int 변환";
            this.BtnInt.UseVisualStyleBackColor = true;
            this.BtnInt.Click += new System.EventHandler(this.BtnInt_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Location = new System.Drawing.Point(268, 174);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(113, 31);
            this.BtnDouble.TabIndex = 12;
            this.BtnDouble.Text = "Double 변환";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 357);
            this.Controls.Add(this.BtnDouble);
            this.Controls.Add(this.BtnInt);
            this.Controls.Add(this.BtnShort);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEx);
            this.Controls.Add(this.tboxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Button BtnEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Button BtnShort;
        private System.Windows.Forms.Button BtnInt;
        private System.Windows.Forms.Button BtnDouble;
    }
}

