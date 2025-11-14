namespace QuizApp
{
    partial class QuizForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel pnlAnswers;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnlAnswers = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÀI THI TRẮC NGHIỆM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuestionNumber.Location = new System.Drawing.Point(20, 60);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(70, 18);
            this.lblQuestionNumber.TabIndex = 1;
            this.lblQuestionNumber.Text = "Câu 1/20";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Green;
            this.lblTimer.Location = new System.Drawing.Point(620, 60);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(140, 18);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Thời gian: 30:00";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.lblStatus.Location = new System.Drawing.Point(300, 62);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 3;
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.pnlAnswers);
            this.grpQuestion.Controls.Add(this.lblQuestion);
            this.grpQuestion.Font = new System.Drawing.Font("Arial", 10F);
            this.grpQuestion.Location = new System.Drawing.Point(20, 90);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(740, 350);
            this.grpQuestion.TabIndex = 4;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Câu hỏi";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = false;
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 11F);
            this.lblQuestion.Location = new System.Drawing.Point(15, 30);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(710, 60);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Câu hỏi sẽ hiển thị ở đây...";
            // 
            // pnlAnswers
            // 
            this.pnlAnswers.AutoScroll = true;
            this.pnlAnswers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnswers.Location = new System.Drawing.Point(15, 100);
            this.pnlAnswers.Name = "pnlAnswers";
            this.pnlAnswers.Size = new System.Drawing.Size(710, 235);
            this.pnlAnswers.TabIndex = 1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gray;
            this.btnPrevious.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(20, 460);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(200, 45);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "← Câu trước";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Green;
            this.btnNext.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(560, 460);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(200, 45);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Câu tiếp theo →";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.grpQuestion);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm Bài Thi";
            this.grpQuestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}