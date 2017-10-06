namespace BlockingUI
{
    partial class Form1
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
            this.ButtonDoSomethingSlow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonDoSomethingSlow
            // 
            this.ButtonDoSomethingSlow.Location = new System.Drawing.Point(12, 12);
            this.ButtonDoSomethingSlow.Name = "ButtonDoSomethingSlow";
            this.ButtonDoSomethingSlow.Size = new System.Drawing.Size(162, 23);
            this.ButtonDoSomethingSlow.TabIndex = 0;
            this.ButtonDoSomethingSlow.Text = "Do Something Slow";
            this.ButtonDoSomethingSlow.UseVisualStyleBackColor = true;
            this.ButtonDoSomethingSlow.Click += new System.EventHandler(this.ButtonDoSomethingSlow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtonDoSomethingSlow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonDoSomethingSlow;
    }
}

