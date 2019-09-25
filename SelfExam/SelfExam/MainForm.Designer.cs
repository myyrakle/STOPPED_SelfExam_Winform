namespace SelfExam
{
    partial class SelfExam
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
            this.CreateNewExamButton = new System.Windows.Forms.Button();
            this.OpenExamButton = new System.Windows.Forms.Button();
            this.EditExamButton = new System.Windows.Forms.Button();
            this.OpenSettingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewExamButton
            // 
            this.CreateNewExamButton.Location = new System.Drawing.Point(12, 12);
            this.CreateNewExamButton.Name = "CreateNewExamButton";
            this.CreateNewExamButton.Size = new System.Drawing.Size(101, 34);
            this.CreateNewExamButton.TabIndex = 0;
            this.CreateNewExamButton.Text = "새 시험 생성";
            this.CreateNewExamButton.UseVisualStyleBackColor = true;
            this.CreateNewExamButton.Click += new System.EventHandler(this.CreateNewExamButton_Click);
            // 
            // OpenExamButton
            // 
            this.OpenExamButton.Location = new System.Drawing.Point(12, 62);
            this.OpenExamButton.Name = "OpenExamButton";
            this.OpenExamButton.Size = new System.Drawing.Size(101, 34);
            this.OpenExamButton.TabIndex = 1;
            this.OpenExamButton.Text = "시험 열기";
            this.OpenExamButton.UseVisualStyleBackColor = true;
            this.OpenExamButton.Click += new System.EventHandler(this.OpenExamButton_Click);
            // 
            // EditExamButton
            // 
            this.EditExamButton.Location = new System.Drawing.Point(137, 62);
            this.EditExamButton.Name = "EditExamButton";
            this.EditExamButton.Size = new System.Drawing.Size(101, 34);
            this.EditExamButton.TabIndex = 2;
            this.EditExamButton.Text = "시험 편집";
            this.EditExamButton.UseVisualStyleBackColor = true;
            this.EditExamButton.Click += new System.EventHandler(this.EditExamButton_Click);
            // 
            // OpenSettingButton
            // 
            this.OpenSettingButton.Location = new System.Drawing.Point(137, 13);
            this.OpenSettingButton.Name = "OpenSettingButton";
            this.OpenSettingButton.Size = new System.Drawing.Size(101, 33);
            this.OpenSettingButton.TabIndex = 3;
            this.OpenSettingButton.Text = "설정";
            this.OpenSettingButton.UseVisualStyleBackColor = true;
            // 
            // SelfExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 108);
            this.Controls.Add(this.OpenSettingButton);
            this.Controls.Add(this.EditExamButton);
            this.Controls.Add(this.OpenExamButton);
            this.Controls.Add(this.CreateNewExamButton);
            this.Name = "SelfExam";
            this.Text = "SelfExam";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewExamButton;
        private System.Windows.Forms.Button OpenExamButton;
        private System.Windows.Forms.Button EditExamButton;
        private System.Windows.Forms.Button OpenSettingButton;
    }
}

