namespace AsyncPatterWinForms
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
            this.bBlock = new System.Windows.Forms.Button();
            this.bAsync = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bBlock
            // 
            this.bBlock.Location = new System.Drawing.Point(12, 12);
            this.bBlock.Name = "bBlock";
            this.bBlock.Size = new System.Drawing.Size(118, 55);
            this.bBlock.TabIndex = 0;
            this.bBlock.Text = "Blocking";
            this.bBlock.UseVisualStyleBackColor = true;
            this.bBlock.Click += new System.EventHandler(this.bBlock_Click);
            // 
            // bAsync
            // 
            this.bAsync.Location = new System.Drawing.Point(12, 73);
            this.bAsync.Name = "bAsync";
            this.bAsync.Size = new System.Drawing.Size(118, 57);
            this.bAsync.TabIndex = 1;
            this.bAsync.Text = "Async";
            this.bAsync.UseVisualStyleBackColor = true;
            this.bAsync.Click += new System.EventHandler(this.bAsync_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(178, 59);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(223, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 2;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResult.Location = new System.Drawing.Point(12, 152);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(70, 25);
            this.lResult.TabIndex = 3;
            this.lResult.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 232);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bAsync);
            this.Controls.Add(this.bBlock);
            this.Name = "MainForm";
            this.Text = "Async Pattern Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBlock;
        private System.Windows.Forms.Button bAsync;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lResult;
    }
}

