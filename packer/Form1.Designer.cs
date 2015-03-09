namespace packer
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbNickname = new System.Windows.Forms.Label();
            this.lbMabiPath = new System.Windows.Forms.Label();
            this.lbVf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(83, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 256);
            this.listBox1.TabIndex = 0;
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Location = new System.Drawing.Point(12, 9);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(89, 12);
            this.lbNickname.TabIndex = 1;
            this.lbNickname.Text = "nickname here";
            // 
            // lbMabiPath
            // 
            this.lbMabiPath.AutoSize = true;
            this.lbMabiPath.Location = new System.Drawing.Point(12, 21);
            this.lbMabiPath.Name = "lbMabiPath";
            this.lbMabiPath.Size = new System.Drawing.Size(114, 12);
            this.lbMabiPath.TabIndex = 2;
            this.lbMabiPath.Text = "mabinogi path here";
            // 
            // lbVf
            // 
            this.lbVf.AutoSize = true;
            this.lbVf.Location = new System.Drawing.Point(12, 33);
            this.lbVf.Name = "lbVf";
            this.lbVf.Size = new System.Drawing.Size(43, 12);
            this.lbVf.TabIndex = 3;
            this.lbVf.Text = "vf here";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 59);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 432);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbVf);
            this.Controls.Add(this.lbMabiPath);
            this.Controls.Add(this.lbNickname);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label lbMabiPath;
        private System.Windows.Forms.Label lbVf;
        private System.Windows.Forms.TextBox textBox1;
    }
}

