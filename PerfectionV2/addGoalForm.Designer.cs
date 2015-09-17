namespace PerfectionV2
{
    partial class addGoalForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.goalNameBx = new System.Windows.Forms.TextBox();
            this.goalDescBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskRad = new System.Windows.Forms.RadioButton();
            this.shortRad = new System.Windows.Forms.RadioButton();
            this.longRad = new System.Windows.Forms.RadioButton();
            this.goalListChkBx = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.estHoursUpDwn = new System.Windows.Forms.NumericUpDown();
            this.cateComboBx = new System.Windows.Forms.ComboBox();
            this.goalChkBxLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estHoursUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(221, 288);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(103, 39);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(59, 288);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(103, 39);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // goalNameBx
            // 
            this.goalNameBx.Location = new System.Drawing.Point(104, 32);
            this.goalNameBx.Name = "goalNameBx";
            this.goalNameBx.Size = new System.Drawing.Size(220, 20);
            this.goalNameBx.TabIndex = 2;
            // 
            // goalDescBx
            // 
            this.goalDescBx.Location = new System.Drawing.Point(104, 72);
            this.goalDescBx.Name = "goalDescBx";
            this.goalDescBx.Size = new System.Drawing.Size(220, 20);
            this.goalDescBx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Goal Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Goal Description";
            // 
            // taskRad
            // 
            this.taskRad.AutoSize = true;
            this.taskRad.Location = new System.Drawing.Point(38, 225);
            this.taskRad.Name = "taskRad";
            this.taskRad.Size = new System.Drawing.Size(49, 17);
            this.taskRad.TabIndex = 6;
            this.taskRad.TabStop = true;
            this.taskRad.Text = "Task";
            this.taskRad.UseVisualStyleBackColor = true;
            this.taskRad.CheckedChanged += new System.EventHandler(this.taskRad_CheckedChanged);
            // 
            // shortRad
            // 
            this.shortRad.AutoSize = true;
            this.shortRad.Location = new System.Drawing.Point(127, 225);
            this.shortRad.Name = "shortRad";
            this.shortRad.Size = new System.Drawing.Size(77, 17);
            this.shortRad.TabIndex = 7;
            this.shortRad.TabStop = true;
            this.shortRad.Text = "Short Term";
            this.shortRad.UseVisualStyleBackColor = true;
            this.shortRad.CheckedChanged += new System.EventHandler(this.shortRad_CheckedChanged);
            // 
            // longRad
            // 
            this.longRad.AutoSize = true;
            this.longRad.Location = new System.Drawing.Point(248, 225);
            this.longRad.Name = "longRad";
            this.longRad.Size = new System.Drawing.Size(76, 17);
            this.longRad.TabIndex = 8;
            this.longRad.TabStop = true;
            this.longRad.Text = "Long Term";
            this.longRad.UseVisualStyleBackColor = true;
            this.longRad.CheckedChanged += new System.EventHandler(this.longRad_CheckedChanged);
            // 
            // goalListChkBx
            // 
            this.goalListChkBx.CheckOnClick = true;
            this.goalListChkBx.FormattingEnabled = true;
            this.goalListChkBx.Location = new System.Drawing.Point(405, 62);
            this.goalListChkBx.Name = "goalListChkBx";
            this.goalListChkBx.Size = new System.Drawing.Size(149, 319);
            this.goalListChkBx.TabIndex = 9;
            this.goalListChkBx.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estimated Hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Goal Category:";
            // 
            // estHoursUpDwn
            // 
            this.estHoursUpDwn.Location = new System.Drawing.Point(104, 117);
            this.estHoursUpDwn.Name = "estHoursUpDwn";
            this.estHoursUpDwn.Size = new System.Drawing.Size(120, 20);
            this.estHoursUpDwn.TabIndex = 13;
            // 
            // cateComboBx
            // 
            this.cateComboBx.FormattingEnabled = true;
            this.cateComboBx.Items.AddRange(new object[] {
            "Career",
            "Health",
            "Interpersonal",
            "Hobby"});
            this.cateComboBx.Location = new System.Drawing.Point(104, 159);
            this.cateComboBx.Name = "cateComboBx";
            this.cateComboBx.Size = new System.Drawing.Size(121, 21);
            this.cateComboBx.TabIndex = 14;
            this.cateComboBx.SelectedIndexChanged += new System.EventHandler(this.cateComboBx_SelectedIndexChanged);
            // 
            // goalChkBxLb
            // 
            this.goalChkBxLb.AutoSize = true;
            this.goalChkBxLb.Location = new System.Drawing.Point(405, 43);
            this.goalChkBxLb.Name = "goalChkBxLb";
            this.goalChkBxLb.Size = new System.Drawing.Size(36, 13);
            this.goalChkBxLb.TabIndex = 15;
            this.goalChkBxLb.Text = "None:";
            // 
            // addGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 420);
            this.Controls.Add(this.goalChkBxLb);
            this.Controls.Add(this.cateComboBx);
            this.Controls.Add(this.estHoursUpDwn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goalListChkBx);
            this.Controls.Add(this.longRad);
            this.Controls.Add(this.shortRad);
            this.Controls.Add(this.taskRad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goalDescBx);
            this.Controls.Add(this.goalNameBx);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "addGoalForm";
            this.Text = "Add Goal";
            this.Load += new System.EventHandler(this.addGoalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estHoursUpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox goalNameBx;
        private System.Windows.Forms.TextBox goalDescBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton taskRad;
        private System.Windows.Forms.RadioButton shortRad;
        private System.Windows.Forms.RadioButton longRad;
        private System.Windows.Forms.CheckedListBox goalListChkBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown estHoursUpDwn;
        private System.Windows.Forms.ComboBox cateComboBx;
        private System.Windows.Forms.Label goalChkBxLb;
    }
}