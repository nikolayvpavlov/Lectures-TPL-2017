namespace ResponsiveUIDemo
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
            this.ButtonCallNetwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCallNetwork
            // 
            this.ButtonCallNetwork.Location = new System.Drawing.Point(12, 12);
            this.ButtonCallNetwork.Name = "ButtonCallNetwork";
            this.ButtonCallNetwork.Size = new System.Drawing.Size(168, 23);
            this.ButtonCallNetwork.TabIndex = 0;
            this.ButtonCallNetwork.Text = "Network call";
            this.ButtonCallNetwork.UseVisualStyleBackColor = true;
            this.ButtonCallNetwork.Click += new System.EventHandler(this.ButtonCallNetwork_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtonCallNetwork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCallNetwork;
    }
}

