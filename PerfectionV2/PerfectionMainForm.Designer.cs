namespace PerfectionV2
{
    partial class PerfectionMain
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
            this.outputBox = new System.Windows.Forms.TextBox();
            this.createProfBtn = new System.Windows.Forms.Button();
            this.loadProfBtn = new System.Windows.Forms.Button();
            this.listGoalsBtn = new System.Windows.Forms.Button();
            this.saveProfBtn = new System.Windows.Forms.Button();
            this.addGoalBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.completeGoalBtn = new System.Windows.Forms.Button();
            this.profNameLb = new System.Windows.Forms.Label();
            this.proflevelLb = new System.Windows.Forms.Label();
            this.expProgBar = new System.Windows.Forms.ProgressBar();
            this.profExp = new System.Windows.Forms.Label();
            this.removeGoalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.outputBox.Location = new System.Drawing.Point(577, 12);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(679, 607);
            this.outputBox.TabIndex = 0;
            // 
            // createProfBtn
            // 
            this.createProfBtn.Location = new System.Drawing.Point(12, 12);
            this.createProfBtn.Name = "createProfBtn";
            this.createProfBtn.Size = new System.Drawing.Size(112, 46);
            this.createProfBtn.TabIndex = 1;
            this.createProfBtn.Text = "Create Profile";
            this.createProfBtn.UseVisualStyleBackColor = true;
            this.createProfBtn.Click += new System.EventHandler(this.createProfBtn_Click);
            // 
            // loadProfBtn
            // 
            this.loadProfBtn.Location = new System.Drawing.Point(12, 134);
            this.loadProfBtn.Name = "loadProfBtn";
            this.loadProfBtn.Size = new System.Drawing.Size(112, 46);
            this.loadProfBtn.TabIndex = 2;
            this.loadProfBtn.Text = "Load Profile";
            this.loadProfBtn.UseVisualStyleBackColor = true;
            this.loadProfBtn.Click += new System.EventHandler(this.loadProfBtn_Click);
            // 
            // listGoalsBtn
            // 
            this.listGoalsBtn.Location = new System.Drawing.Point(12, 260);
            this.listGoalsBtn.Name = "listGoalsBtn";
            this.listGoalsBtn.Size = new System.Drawing.Size(112, 46);
            this.listGoalsBtn.TabIndex = 3;
            this.listGoalsBtn.Text = "List Goals";
            this.listGoalsBtn.UseVisualStyleBackColor = true;
            this.listGoalsBtn.Click += new System.EventHandler(this.listGoalsBtn_Click);
            // 
            // saveProfBtn
            // 
            this.saveProfBtn.Location = new System.Drawing.Point(12, 73);
            this.saveProfBtn.Name = "saveProfBtn";
            this.saveProfBtn.Size = new System.Drawing.Size(112, 46);
            this.saveProfBtn.TabIndex = 4;
            this.saveProfBtn.Text = "Save Profile";
            this.saveProfBtn.UseVisualStyleBackColor = true;
            this.saveProfBtn.Click += new System.EventHandler(this.saveProfBtn_Click);
            // 
            // addGoalBtn
            // 
            this.addGoalBtn.Location = new System.Drawing.Point(12, 196);
            this.addGoalBtn.Name = "addGoalBtn";
            this.addGoalBtn.Size = new System.Drawing.Size(112, 46);
            this.addGoalBtn.TabIndex = 5;
            this.addGoalBtn.Text = "Add Goal";
            this.addGoalBtn.UseVisualStyleBackColor = true;
            this.addGoalBtn.Click += new System.EventHandler(this.addGoalBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(12, 573);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(112, 46);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // completeGoalBtn
            // 
            this.completeGoalBtn.Location = new System.Drawing.Point(12, 324);
            this.completeGoalBtn.Name = "completeGoalBtn";
            this.completeGoalBtn.Size = new System.Drawing.Size(112, 46);
            this.completeGoalBtn.TabIndex = 7;
            this.completeGoalBtn.Text = "Complete Goal";
            this.completeGoalBtn.UseVisualStyleBackColor = true;
            this.completeGoalBtn.Click += new System.EventHandler(this.completeGoalBtn_Click);
            // 
            // profNameLb
            // 
            this.profNameLb.AutoSize = true;
            this.profNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profNameLb.Location = new System.Drawing.Point(162, 20);
            this.profNameLb.Name = "profNameLb";
            this.profNameLb.Size = new System.Drawing.Size(80, 26);
            this.profNameLb.TabIndex = 8;
            this.profNameLb.Text = "Profile:";
            // 
            // proflevelLb
            // 
            this.proflevelLb.AutoSize = true;
            this.proflevelLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proflevelLb.Location = new System.Drawing.Point(172, 73);
            this.proflevelLb.Name = "proflevelLb";
            this.proflevelLb.Size = new System.Drawing.Size(70, 26);
            this.proflevelLb.TabIndex = 9;
            this.proflevelLb.Text = "Level:";
            // 
            // expProgBar
            // 
            this.expProgBar.Location = new System.Drawing.Point(12, 534);
            this.expProgBar.Name = "expProgBar";
            this.expProgBar.Size = new System.Drawing.Size(548, 19);
            this.expProgBar.TabIndex = 10;
            // 
            // profExp
            // 
            this.profExp.AutoSize = true;
            this.profExp.Location = new System.Drawing.Point(164, 518);
            this.profExp.Name = "profExp";
            this.profExp.Size = new System.Drawing.Size(28, 13);
            this.profExp.TabIndex = 11;
            this.profExp.Text = "Exp:";
            // 
            // removeGoalBtn
            // 
            this.removeGoalBtn.Location = new System.Drawing.Point(12, 387);
            this.removeGoalBtn.Name = "removeGoalBtn";
            this.removeGoalBtn.Size = new System.Drawing.Size(112, 46);
            this.removeGoalBtn.TabIndex = 12;
            this.removeGoalBtn.Text = "Remove Goals";
            this.removeGoalBtn.UseVisualStyleBackColor = true;
            this.removeGoalBtn.Click += new System.EventHandler(this.removeGoalBtn_Click);
            // 
            // PerfectionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 631);
            this.Controls.Add(this.removeGoalBtn);
            this.Controls.Add(this.profExp);
            this.Controls.Add(this.expProgBar);
            this.Controls.Add(this.proflevelLb);
            this.Controls.Add(this.profNameLb);
            this.Controls.Add(this.completeGoalBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.addGoalBtn);
            this.Controls.Add(this.saveProfBtn);
            this.Controls.Add(this.listGoalsBtn);
            this.Controls.Add(this.loadProfBtn);
            this.Controls.Add(this.createProfBtn);
            this.Controls.Add(this.outputBox);
            this.Name = "PerfectionMain";
            this.Text = "PerfectionV2";
            this.Load += new System.EventHandler(this.PerfectionMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button createProfBtn;
        private System.Windows.Forms.Button loadProfBtn;
        private System.Windows.Forms.Button listGoalsBtn;
        private System.Windows.Forms.Button saveProfBtn;
        private System.Windows.Forms.Button addGoalBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button completeGoalBtn;
        private System.Windows.Forms.Label profNameLb;
        private System.Windows.Forms.Label proflevelLb;
        private System.Windows.Forms.ProgressBar expProgBar;
        private System.Windows.Forms.Label profExp;
        private System.Windows.Forms.Button removeGoalBtn;
    }
}

