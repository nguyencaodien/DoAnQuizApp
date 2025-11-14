namespace QuizApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSelectQuiz;
        private System.Windows.Forms.ComboBox cmbQuizzes;
        private System.Windows.Forms.Label lblQuizInfo;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpQuizInfo;

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
            this.lblSelectQuiz = new System.Windows.Forms.Label();
            this.cmbQuizzes = new System.Windows.Forms.ComboBox();
            this.lblQuizInfo = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpQuizInfo = new System.Windows.Forms.GroupBox();
            this.grpQuizInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(560, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG TRẮC NGHIỆM ONLINE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectQuiz
            // 
            this.lblSelectQuiz.AutoSize = true;
            this.lblSelectQuiz.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSelectQuiz.Location = new System.Drawing.Point(30, 75);
            this.lblSelectQuiz.Name = "lblSelectQuiz";
            this.lblSelectQuiz.Size = new System.Drawing.Size(90, 16);
            this.lblSelectQuiz.TabIndex = 1;
            this.lblSelectQuiz.Text = "Chọn đề thi:";
            // 
            // cmbQuizzes
            // 
            this.cmbQuizzes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuizzes.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbQuizzes.FormattingEnabled = true;
            this.cmbQuizzes.Location = new System.Drawing.Point(140, 72);
            this.cmbQuizzes.Name = "cmbQuizzes";
            this.cmbQuizzes.Size = new System.Drawing.Size(400, 24);
            this.cmbQuizzes.TabIndex = 2;
            this.cmbQuizzes.SelectedIndexChanged += new System.EventHandler(this.cmbQuizzes_SelectedIndexChanged);
            // 
            // grpQuizInfo
            // 
            this.grpQuizInfo.Controls.Add(this.lblQuizInfo);
            this.grpQuizInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.grpQuizInfo.Location = new System.Drawing.Point(30, 110);
            this.grpQuizInfo.Name = "grpQuizInfo";
            this.grpQuizInfo.Size = new System.Drawing.Size(510, 120);
            this.grpQuizInfo.TabIndex = 3;
            this.grpQuizInfo.TabStop = false;
            this.grpQuizInfo.Text = "Thông tin đề thi";
            // 
            // lblQuizInfo
            // 
            this.lblQuizInfo.AutoSize = false;
            this.lblQuizInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.lblQuizInfo.Location = new System.Drawing.Point(15, 25);
            this.lblQuizInfo.Name = "lblQuizInfo";
            this.lblQuizInfo.Size = new System.Drawing.Size(480, 85);
            this.lblQuizInfo.TabIndex = 0;
            this.lblQuizInfo.Text = "Chọn một đề thi để xem thông tin...";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStudentName.Location = new System.Drawing.Point(30, 250);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(100, 16);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Tên của bạn:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtStudentName.Location = new System.Drawing.Point(140, 247);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(400, 23);
            this.txtStudentName.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(30, 295);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(250, 45);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "BẮT ĐẦU LÀM BÀI";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewResults.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnViewResults.ForeColor = System.Drawing.Color.White;
            this.btnViewResults.Location = new System.Drawing.Point(290, 295);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(250, 45);
            this.btnViewResults.TabIndex = 7;
            this.btnViewResults.Text = "XEM KẾT QUẢ";
            this.btnViewResults.UseVisualStyleBackColor = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Orange;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(30, 355);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(250, 40);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "LÀM MỚI DỮ LIỆU";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(290, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnViewResults);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.grpQuizInfo);
            this.Controls.Add(this.cmbQuizzes);
            this.Controls.Add(this.lblSelectQuiz);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Trắc Nghiệm";
            this.grpQuizInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}