namespace PerfectionV2
{
    partial class removeGoalForm
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
            this.goalLb = new System.Windows.Forms.Label();
            this.goalChkBx = new System.Windows.Forms.CheckedListBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.rmvGoalSoloChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // goalLb
            // 
            this.goalLb.AutoSize = true;
            this.goalLb.Location = new System.Drawing.Point(44, 62);
            this.goalLb.Name = "goalLb";
            this.goalLb.Size = new System.Drawing.Size(37, 13);
            this.goalLb.TabIndex = 11;
            this.goalLb.Text = "Goals:";
            // 
            // goalChkBx
            // 
            this.goalChkBx.CheckOnClick = true;
            this.goalChkBx.FormattingEnabled = true;
            this.goalChkBx.Location = new System.Drawing.Point(87, 41);
            this.goalChkBx.Name = "goalChkBx";
            this.goalChkBx.Size = new System.Drawing.Size(186, 424);
            this.goalChkBx.TabIndex = 10;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(54, 507);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(112, 46);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(217, 507);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 46);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // rmvGoalSoloChk
            // 
            this.rmvGoalSoloChk.AutoSize = true;
            this.rmvGoalSoloChk.Location = new System.Drawing.Point(132, 12);
            this.rmvGoalSoloChk.Name = "rmvGoalSoloChk";
            this.rmvGoalSoloChk.Size = new System.Drawing.Size(242, 17);
            this.rmvGoalSoloChk.TabIndex = 15;
            this.rmvGoalSoloChk.Text = "Remove Goals without removing their children";
            this.rmvGoalSoloChk.UseVisualStyleBackColor = true;
            // 
            // removeGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 585);
            this.Controls.Add(this.rmvGoalSoloChk);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.goalLb);
            this.Controls.Add(this.goalChkBx);
            this.Name = "removeGoalForm";
            this.Text = "Remove Goals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goalLb;
        private System.Windows.Forms.CheckedListBox goalChkBx;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox rmvGoalSoloChk;
    }
}