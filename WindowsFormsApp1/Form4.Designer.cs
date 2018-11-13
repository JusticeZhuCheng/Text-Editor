namespace WindowsFormsApp1
{
    partial class About
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.Detail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(50, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(186, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name: Text Editor Alpha";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(161, 261);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Version.Location = new System.Drawing.Point(50, 119);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(104, 20);
            this.Version.TabIndex = 2;
            this.Version.Text = "Version: V0.1";
            // 
            // Detail
            // 
            this.Detail.AutoSize = true;
            this.Detail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Detail.Location = new System.Drawing.Point(50, 165);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(293, 40);
            this.Detail.TabIndex = 3;
            this.Detail.Text = "Functions:  Open, create and save files. \r\nCopy, paste and cut the text";
            this.Detail.Click += new System.EventHandler(this.Detail_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 325);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.NameLabel);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Detail;
    }
}