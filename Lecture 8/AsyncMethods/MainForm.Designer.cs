namespace AsyncMethods
{
    partial class MainForm
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
            this.bDoWork = new System.Windows.Forms.Button();
            this.ButtonGetQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bDoWork
            // 
            this.bDoWork.Location = new System.Drawing.Point(12, 12);
            this.bDoWork.Name = "bDoWork";
            this.bDoWork.Size = new System.Drawing.Size(119, 60);
            this.bDoWork.TabIndex = 0;
            this.bDoWork.Text = "Do Work";
            this.bDoWork.UseVisualStyleBackColor = true;
            this.bDoWork.Click += new System.EventHandler(this.bDoWork_Click);
            // 
            // ButtonGetQuote
            // 
            this.ButtonGetQuote.Location = new System.Drawing.Point(12, 103);
            this.ButtonGetQuote.Name = "ButtonGetQuote";
            this.ButtonGetQuote.Size = new System.Drawing.Size(119, 68);
            this.ButtonGetQuote.TabIndex = 1;
            this.ButtonGetQuote.Text = "Get Quote";
            this.ButtonGetQuote.UseVisualStyleBackColor = true;
            this.ButtonGetQuote.Click += new System.EventHandler(this.ButtonGetQuote_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.ButtonGetQuote);
            this.Controls.Add(this.bDoWork);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bDoWork;
        private System.Windows.Forms.Button ButtonGetQuote;
    }
}

