namespace GuessingGame
{
    partial class CapitolGuesser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapitolGuesser));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.CityList = new System.Windows.Forms.ListBox();
            this.txtAttempts = new System.Windows.Forms.TextBox();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.Countdown = new System.Windows.Forms.Timer(this.components);
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblright = new System.Windows.Forms.Label();
            this.lblwrong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(3, 16);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(297, 18);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "What is the capital of";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CityList
            // 
            this.CityList.FormattingEnabled = true;
            this.CityList.Location = new System.Drawing.Point(321, 9);
            this.CityList.Name = "CityList";
            this.CityList.Size = new System.Drawing.Size(160, 251);
            this.CityList.TabIndex = 1;
            // 
            // txtAttempts
            // 
            this.txtAttempts.Location = new System.Drawing.Point(89, 32);
            this.txtAttempts.Name = "txtAttempts";
            this.txtAttempts.ReadOnly = true;
            this.txtAttempts.Size = new System.Drawing.Size(49, 20);
            this.txtAttempts.TabIndex = 2;
            this.txtAttempts.Text = "0";
            this.txtAttempts.TextChanged += new System.EventHandler(this.txtAttempts_TextChanged);
            // 
            // txtCorrect
            // 
            this.txtCorrect.Location = new System.Drawing.Point(6, 32);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.ReadOnly = true;
            this.txtCorrect.Size = new System.Drawing.Size(49, 20);
            this.txtCorrect.TabIndex = 3;
            this.txtCorrect.Text = "0";
            this.txtCorrect.TextChanged += new System.EventHandler(this.txtCorrect_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attempts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correct";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(16, 263);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(153, 263);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "Exit";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Countdown
            // 
            this.Countdown.Enabled = true;
            this.Countdown.Interval = 1000;
            this.Countdown.Tick += new System.EventHandler(this.Countdown_Tick);
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(165, 8);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(29, 20);
            this.lblTimeRemaining.TabIndex = 8;
            this.lblTimeRemaining.Text = "15";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(365, 267);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 9;
            this.btnChoose.Text = "Select";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblright
            // 
            this.lblright.AutoSize = true;
            this.lblright.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblright.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblright.Location = new System.Drawing.Point(132, 217);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(96, 25);
            this.lblright.TabIndex = 10;
            this.lblright.Text = "Correct!";
            this.lblright.Visible = false;
            // 
            // lblwrong
            // 
            this.lblwrong.AutoSize = true;
            this.lblwrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwrong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblwrong.Location = new System.Drawing.Point(117, 217);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(111, 25);
            this.lblwrong.TabIndex = 11;
            this.lblwrong.Text = "Incorrect!";
            this.lblwrong.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 49);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPercent);
            this.groupBox2.Controls.Add(this.txtCorrect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAttempts);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(99, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 105);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Percent Correct";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(47, 79);
            this.txtPercent.MaxLength = 4;
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.ReadOnly = true;
            this.txtPercent.Size = new System.Drawing.Size(49, 20);
            this.txtPercent.TabIndex = 6;
            this.txtPercent.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time Remaining:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblTimeRemaining);
            this.groupBox3.Location = new System.Drawing.Point(70, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 30);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // CapitolGuesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 302);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblwrong);
            this.Controls.Add(this.lblright);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.CityList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CapitolGuesser";
            this.Text = "Capital Guesser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ListBox CityList;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Timer Countdown;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblright;
        private System.Windows.Forms.Label lblwrong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

