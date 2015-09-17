namespace PerfectionV2
{
    partial class loadProfileForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.profNameBx = new System.Windows.Forms.TextBox();
            this.subProfBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(54, 108);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // profNameBx
            // 
            this.profNameBx.Location = new System.Drawing.Point(98, 105);
            this.profNameBx.Name = "profNameBx";
            this.profNameBx.Size = new System.Drawing.Size(100, 20);
            this.profNameBx.TabIndex = 2;
            // 
            // subProfBtn
            // 
            this.subProfBtn.Location = new System.Drawing.Point(30, 170);
            this.subProfBtn.Name = "subProfBtn";
            this.subProfBtn.Size = new System.Drawing.Size(100, 38);
            this.subProfBtn.TabIndex = 5;
            this.subProfBtn.Text = "Submit";
            this.subProfBtn.UseVisualStyleBackColor = true;
            this.subProfBtn.Click += new System.EventHandler(this.subProfBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(145, 170);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 38);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loadProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.subProfBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profNameBx);
            this.Name = "loadProfileForm";
            this.Text = "Load Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox profNameBx;
        private System.Windows.Forms.Button subProfBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}