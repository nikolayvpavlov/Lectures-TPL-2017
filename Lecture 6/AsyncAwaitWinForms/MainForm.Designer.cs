namespace AsyncAwaitWinForms
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
            this.bCallDb = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bCallDb
            // 
            this.bCallDb.Location = new System.Drawing.Point(12, 12);
            this.bCallDb.Name = "bCallDb";
            this.bCallDb.Size = new System.Drawing.Size(75, 23);
            this.bCallDb.TabIndex = 0;
            this.bCallDb.Text = "Call Db";
            this.bCallDb.UseVisualStyleBackColor = true;
            this.bCallDb.Click += new System.EventHandler(this.bCallDb_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(12, 65);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(70, 25);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "label1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(139, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(281, 23);
            this.progressBar.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 266);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.bCallDb);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCallDb;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

