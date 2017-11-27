namespace CompositeTwoImages
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loadSrcButton = new System.Windows.Forms.Button();
            this.loadSubButton = new System.Windows.Forms.Button();
            this.compositeButton = new System.Windows.Forms.Button();
            this.srcPictureBox = new System.Windows.Forms.PictureBox();
            this.subPictureBox = new System.Windows.Forms.PictureBox();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.srcPictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 349);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.subPictureBox);
            this.panel2.Location = new System.Drawing.Point(374, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 349);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.resultPictureBox);
            this.panel3.Location = new System.Drawing.Point(730, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 349);
            this.panel3.TabIndex = 2;
            // 
            // loadSrcButton
            // 
            this.loadSrcButton.Location = new System.Drawing.Point(12, 379);
            this.loadSrcButton.Name = "loadSrcButton";
            this.loadSrcButton.Size = new System.Drawing.Size(291, 23);
            this.loadSrcButton.TabIndex = 3;
            this.loadSrcButton.Text = "Load";
            this.loadSrcButton.UseVisualStyleBackColor = true;
            this.loadSrcButton.Click += new System.EventHandler(this.loadSrcButton_Click);
            // 
            // loadSubButton
            // 
            this.loadSubButton.Location = new System.Drawing.Point(374, 379);
            this.loadSubButton.Name = "loadSubButton";
            this.loadSubButton.Size = new System.Drawing.Size(291, 23);
            this.loadSubButton.TabIndex = 4;
            this.loadSubButton.Text = "Load";
            this.loadSubButton.UseVisualStyleBackColor = true;
            this.loadSubButton.Click += new System.EventHandler(this.loadSubButton_Click);
            // 
            // compositeButton
            // 
            this.compositeButton.Location = new System.Drawing.Point(730, 379);
            this.compositeButton.Name = "compositeButton";
            this.compositeButton.Size = new System.Drawing.Size(291, 23);
            this.compositeButton.TabIndex = 5;
            this.compositeButton.Text = "Composite";
            this.compositeButton.UseVisualStyleBackColor = true;
            this.compositeButton.Click += new System.EventHandler(this.compositeButton_Click);
            // 
            // srcPictureBox
            // 
            this.srcPictureBox.Location = new System.Drawing.Point(11, 8);
            this.srcPictureBox.Name = "srcPictureBox";
            this.srcPictureBox.Size = new System.Drawing.Size(267, 331);
            this.srcPictureBox.TabIndex = 0;
            this.srcPictureBox.TabStop = false;
            // 
            // subPictureBox
            // 
            this.subPictureBox.Location = new System.Drawing.Point(12, 8);
            this.subPictureBox.Name = "subPictureBox";
            this.subPictureBox.Size = new System.Drawing.Size(267, 331);
            this.subPictureBox.TabIndex = 1;
            this.subPictureBox.TabStop = false;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(12, 8);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(267, 331);
            this.resultPictureBox.TabIndex = 6;
            this.resultPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(327, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(687, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compositeButton);
            this.Controls.Add(this.loadSubButton);
            this.Controls.Add(this.loadSrcButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox srcPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox subPictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Button loadSrcButton;
        private System.Windows.Forms.Button loadSubButton;
        private System.Windows.Forms.Button compositeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

