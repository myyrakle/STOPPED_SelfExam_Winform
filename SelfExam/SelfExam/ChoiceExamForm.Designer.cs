namespace SelfExam
{
    partial class ChoiceExamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChoiceFileButton = new System.Windows.Forms.Button();
            this.RandomCheckBox = new System.Windows.Forms.CheckBox();
            this.FilenameTextBox = new System.Windows.Forms.TextBox();
            this.RepeatCheckBox = new System.Windows.Forms.CheckBox();
            this.TestStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChoiceFileButton
            // 
            this.ChoiceFileButton.Location = new System.Drawing.Point(237, 12);
            this.ChoiceFileButton.Name = "ChoiceFileButton";
            this.ChoiceFileButton.Size = new System.Drawing.Size(75, 23);
            this.ChoiceFileButton.TabIndex = 0;
            this.ChoiceFileButton.Text = "시험 파일 선택";
            this.ChoiceFileButton.UseVisualStyleBackColor = true;
            this.ChoiceFileButton.Click += new System.EventHandler(this.ChoiceFileButton_Click);
            // 
            // RandomCheckBox
            // 
            this.RandomCheckBox.AutoSize = true;
            this.RandomCheckBox.Location = new System.Drawing.Point(12, 58);
            this.RandomCheckBox.Name = "RandomCheckBox";
            this.RandomCheckBox.Size = new System.Drawing.Size(76, 16);
            this.RandomCheckBox.TabIndex = 1;
            this.RandomCheckBox.Text = "순서 랜덤";
            this.RandomCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilenameTextBox
            // 
            this.FilenameTextBox.Location = new System.Drawing.Point(12, 14);
            this.FilenameTextBox.Name = "FilenameTextBox";
            this.FilenameTextBox.Size = new System.Drawing.Size(218, 21);
            this.FilenameTextBox.TabIndex = 2;
            // 
            // RepeatCheckBox
            // 
            this.RepeatCheckBox.AutoSize = true;
            this.RepeatCheckBox.Location = new System.Drawing.Point(103, 58);
            this.RepeatCheckBox.Name = "RepeatCheckBox";
            this.RepeatCheckBox.Size = new System.Drawing.Size(76, 16);
            this.RepeatCheckBox.TabIndex = 3;
            this.RepeatCheckBox.Text = "무한 반복";
            this.RepeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // TestStartButton
            // 
            this.TestStartButton.Location = new System.Drawing.Point(237, 51);
            this.TestStartButton.Name = "TestStartButton";
            this.TestStartButton.Size = new System.Drawing.Size(75, 23);
            this.TestStartButton.TabIndex = 4;
            this.TestStartButton.Text = "응시";
            this.TestStartButton.UseVisualStyleBackColor = true;
            this.TestStartButton.Click += new System.EventHandler(this.TestStartButton_Click);
            // 
            // ChoiceExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 86);
            this.Controls.Add(this.TestStartButton);
            this.Controls.Add(this.RepeatCheckBox);
            this.Controls.Add(this.FilenameTextBox);
            this.Controls.Add(this.RandomCheckBox);
            this.Controls.Add(this.ChoiceFileButton);
            this.Name = "ChoiceExamForm";
            this.Text = "ChoiceExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChoiceFileButton;
        private System.Windows.Forms.CheckBox RandomCheckBox;
        private System.Windows.Forms.TextBox FilenameTextBox;
        private System.Windows.Forms.CheckBox RepeatCheckBox;
        private System.Windows.Forms.Button TestStartButton;
    }
}