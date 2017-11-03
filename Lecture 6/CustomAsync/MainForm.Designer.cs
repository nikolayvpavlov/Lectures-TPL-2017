namespace CustomAsync
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
            this.ButtonSimple = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bGetResult = new System.Windows.Forms.Button();
            this.ButtonFaulty = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSimple
            // 
            this.ButtonSimple.Location = new System.Drawing.Point(12, 12);
            this.ButtonSimple.Name = "ButtonSimple";
            this.ButtonSimple.Size = new System.Drawing.Size(75, 23);
            this.ButtonSimple.TabIndex = 0;
            this.ButtonSimple.Text = "Simple";
            this.ButtonSimple.UseVisualStyleBackColor = true;
            this.ButtonSimple.Click += new System.EventHandler(this.ButtonSimple_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 226);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(260, 23);
            this.progressBar.TabIndex = 1;
            // 
            // bGetResult
            // 
            this.bGetResult.Location = new System.Drawing.Point(12, 41);
            this.bGetResult.Name = "bGetResult";
            this.bGetResult.Size = new System.Drawing.Size(75, 23);
            this.bGetResult.TabIndex = 2;
            this.bGetResult.Text = "Get Answer";
            this.bGetResult.UseVisualStyleBackColor = true;
            this.bGetResult.Click += new System.EventHandler(this.bGetResult_Click);
            // 
            // ButtonFaulty
            // 
            this.ButtonFaulty.Location = new System.Drawing.Point(12, 70);
            this.ButtonFaulty.Name = "ButtonFaulty";
            this.ButtonFaulty.Size = new System.Drawing.Size(75, 23);
            this.ButtonFaulty.TabIndex = 3;
            this.ButtonFaulty.Text = "Fail";
            this.ButtonFaulty.UseVisualStyleBackColor = true;
            this.ButtonFaulty.Click += new System.EventHandler(this.ButtonFaulty_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonFaulty);
            this.Controls.Add(this.bGetResult);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ButtonSimple);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSimple;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button bGetResult;
        private System.Windows.Forms.Button ButtonFaulty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

