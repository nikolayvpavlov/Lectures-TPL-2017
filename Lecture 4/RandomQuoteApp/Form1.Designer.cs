namespace RandomQuoteApp
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
            this.components = new System.ComponentModel.Container();
            this.LabelQuote = new System.Windows.Forms.Label();
            this.TimerQuote = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelQuote
            // 
            this.LabelQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelQuote.Location = new System.Drawing.Point(330, 9);
            this.LabelQuote.Name = "LabelQuote";
            this.LabelQuote.Size = new System.Drawing.Size(420, 304);
            this.LabelQuote.TabIndex = 0;
            this.LabelQuote.Text = "LabelQuote";
            // 
            // TimerQuote
            // 
            this.TimerQuote.Interval = 5000;
            this.TimerQuote.Tick += new System.EventHandler(this.TimerQuote_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 371);
            this.Controls.Add(this.LabelQuote);
            this.Name = "MainForm";
            this.Text = "Random Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelQuote;
        private System.Windows.Forms.Timer TimerQuote;
    }
}

