namespace GuiThreads
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
            this.ButtonDoSmthBad = new System.Windows.Forms.Button();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonDoSmthBad
            // 
            this.ButtonDoSmthBad.Location = new System.Drawing.Point(12, 12);
            this.ButtonDoSmthBad.Name = "ButtonDoSmthBad";
            this.ButtonDoSmthBad.Size = new System.Drawing.Size(228, 53);
            this.ButtonDoSmthBad.TabIndex = 0;
            this.ButtonDoSmthBad.Text = "Do Something Bad";
            this.ButtonDoSmthBad.UseVisualStyleBackColor = true;
            this.ButtonDoSmthBad.Click += new System.EventHandler(this.ButtonDoSmthBad_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOutput.Location = new System.Drawing.Point(12, 111);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(27, 37);
            this.LabelOutput.TabIndex = 1;
            this.LabelOutput.Text = "-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 341);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.ButtonDoSmthBad);
            this.Name = "MainForm";
            this.Text = "GUI & Threads";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDoSmthBad;
        private System.Windows.Forms.Label LabelOutput;
    }
}

