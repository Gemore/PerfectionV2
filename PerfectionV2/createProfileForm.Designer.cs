namespace PerfectionV2
{
    partial class createProfileForm
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
            this.profNameBx = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profDescBx = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.subProfBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profNameBx
            // 
            this.profNameBx.Location = new System.Drawing.Point(88, 65);
            this.profNameBx.Name = "profNameBx";
            this.profNameBx.Size = new System.Drawing.Size(100, 20);
            this.profNameBx.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(44, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // profDescBx
            // 
            this.profDescBx.Location = new System.Drawing.Point(88, 102);
            this.profDescBx.Name = "profDescBx";
            this.profDescBx.Size = new System.Drawing.Size(100, 20);
            this.profDescBx.TabIndex = 2;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(19, 105);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(63, 13);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Description:";
            // 
            // subProfBtn
            // 
            this.subProfBtn.Location = new System.Drawing.Point(31, 163);
            this.subProfBtn.Name = "subProfBtn";
            this.subProfBtn.Size = new System.Drawing.Size(100, 38);
            this.subProfBtn.TabIndex = 4;
            this.subProfBtn.Text = "Submit";
            this.subProfBtn.UseVisualStyleBackColor = true;
            this.subProfBtn.Click += new System.EventHandler(this.subProfBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(150, 163);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 38);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createProfileForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.subProfBtn);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.profDescBx);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profNameBx);
            this.Name = "createProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox profNameBx;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox profDescBx;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Button subProfBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}