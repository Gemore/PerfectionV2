namespace PerfectionV2
{
    partial class completeGoalForm
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.taskCkhBx = new System.Windows.Forms.CheckedListBox();
            this.shortChkBx = new System.Windows.Forms.CheckedListBox();
            this.longChkBx = new System.Windows.Forms.CheckedListBox();
            this.taskLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.completedBx = new System.Windows.Forms.ListBox();
            this.cmpGoalsLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(465, 351);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(112, 46);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(594, 351);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 46);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // taskCkhBx
            // 
            this.taskCkhBx.CheckOnClick = true;
            this.taskCkhBx.FormattingEnabled = true;
            this.taskCkhBx.Location = new System.Drawing.Point(47, 42);
            this.taskCkhBx.Name = "taskCkhBx";
            this.taskCkhBx.Size = new System.Drawing.Size(148, 289);
            this.taskCkhBx.TabIndex = 6;
            // 
            // shortChkBx
            // 
            this.shortChkBx.CheckOnClick = true;
            this.shortChkBx.FormattingEnabled = true;
            this.shortChkBx.Location = new System.Drawing.Point(280, 42);
            this.shortChkBx.Name = "shortChkBx";
            this.shortChkBx.Size = new System.Drawing.Size(148, 289);
            this.shortChkBx.TabIndex = 7;
            // 
            // longChkBx
            // 
            this.longChkBx.CheckOnClick = true;
            this.longChkBx.FormattingEnabled = true;
            this.longChkBx.Location = new System.Drawing.Point(536, 42);
            this.longChkBx.Name = "longChkBx";
            this.longChkBx.Size = new System.Drawing.Size(148, 289);
            this.longChkBx.TabIndex = 8;
            // 
            // taskLb
            // 
            this.taskLb.AutoSize = true;
            this.taskLb.Location = new System.Drawing.Point(90, 26);
            this.taskLb.Name = "taskLb";
            this.taskLb.Size = new System.Drawing.Size(39, 13);
            this.taskLb.TabIndex = 9;
            this.taskLb.Text = "Tasks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Short-Term Goals:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Long-Term Goals:";
            // 
            // completedBx
            // 
            this.completedBx.FormattingEnabled = true;
            this.completedBx.Location = new System.Drawing.Point(818, 42);
            this.completedBx.Name = "completedBx";
            this.completedBx.Size = new System.Drawing.Size(158, 290);
            this.completedBx.TabIndex = 12;
            // 
            // cmpGoalsLb
            // 
            this.cmpGoalsLb.AutoSize = true;
            this.cmpGoalsLb.Location = new System.Drawing.Point(850, 26);
            this.cmpGoalsLb.Name = "cmpGoalsLb";
            this.cmpGoalsLb.Size = new System.Drawing.Size(87, 13);
            this.cmpGoalsLb.TabIndex = 13;
            this.cmpGoalsLb.Text = "Completed Goals";
            // 
            // completeGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 417);
            this.Controls.Add(this.cmpGoalsLb);
            this.Controls.Add(this.completedBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskLb);
            this.Controls.Add(this.longChkBx);
            this.Controls.Add(this.shortChkBx);
            this.Controls.Add(this.taskCkhBx);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Name = "completeGoalForm";
            this.Text = "Complete Goal";
            this.Load += new System.EventHandler(this.completeGoalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckedListBox taskCkhBx;
        private System.Windows.Forms.CheckedListBox shortChkBx;
        private System.Windows.Forms.CheckedListBox longChkBx;
        private System.Windows.Forms.Label taskLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox completedBx;
        private System.Windows.Forms.Label cmpGoalsLb;
    }
}