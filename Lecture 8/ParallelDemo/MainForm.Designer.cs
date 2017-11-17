namespace ParallelDemo
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
            this.ButtonGetPrimes = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonGetPrimesWithTasks = new System.Windows.Forms.Button();
            this.ButtonGetPrimesParallel = new System.Windows.Forms.Button();
            this.ButtonPrimesParallelLockless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonGetPrimes
            // 
            this.ButtonGetPrimes.Location = new System.Drawing.Point(12, 12);
            this.ButtonGetPrimes.Name = "ButtonGetPrimes";
            this.ButtonGetPrimes.Size = new System.Drawing.Size(183, 66);
            this.ButtonGetPrimes.TabIndex = 0;
            this.ButtonGetPrimes.Text = "Get Primes";
            this.ButtonGetPrimes.UseVisualStyleBackColor = true;
            this.ButtonGetPrimes.Click += new System.EventHandler(this.ButtonGetPrimes_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(216, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(641, 388);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // ButtonGetPrimesWithTasks
            // 
            this.ButtonGetPrimesWithTasks.Location = new System.Drawing.Point(12, 84);
            this.ButtonGetPrimesWithTasks.Name = "ButtonGetPrimesWithTasks";
            this.ButtonGetPrimesWithTasks.Size = new System.Drawing.Size(183, 72);
            this.ButtonGetPrimesWithTasks.TabIndex = 2;
            this.ButtonGetPrimesWithTasks.Text = "Get Primes (Tasks)";
            this.ButtonGetPrimesWithTasks.UseVisualStyleBackColor = true;
            this.ButtonGetPrimesWithTasks.Click += new System.EventHandler(this.ButtonGetPrimesWithTasks_Click);
            // 
            // ButtonGetPrimesParallel
            // 
            this.ButtonGetPrimesParallel.Location = new System.Drawing.Point(12, 162);
            this.ButtonGetPrimesParallel.Name = "ButtonGetPrimesParallel";
            this.ButtonGetPrimesParallel.Size = new System.Drawing.Size(183, 72);
            this.ButtonGetPrimesParallel.TabIndex = 3;
            this.ButtonGetPrimesParallel.Text = "Get Primes (Parallel)";
            this.ButtonGetPrimesParallel.UseVisualStyleBackColor = true;
            this.ButtonGetPrimesParallel.Click += new System.EventHandler(this.ButtonGetPrimesParallel_Click);
            // 
            // ButtonPrimesParallelLockless
            // 
            this.ButtonPrimesParallelLockless.Location = new System.Drawing.Point(12, 240);
            this.ButtonPrimesParallelLockless.Name = "ButtonPrimesParallelLockless";
            this.ButtonPrimesParallelLockless.Size = new System.Drawing.Size(183, 72);
            this.ButtonPrimesParallelLockless.TabIndex = 4;
            this.ButtonPrimesParallelLockless.Text = "Get Primes (Parallel, Lockless)";
            this.ButtonPrimesParallelLockless.UseVisualStyleBackColor = true;
            this.ButtonPrimesParallelLockless.Click += new System.EventHandler(this.ButtonPrimesParallelLockless_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 412);
            this.Controls.Add(this.ButtonPrimesParallelLockless);
            this.Controls.Add(this.ButtonGetPrimesParallel);
            this.Controls.Add(this.ButtonGetPrimesWithTasks);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.ButtonGetPrimes);
            this.Name = "MainForm";
            this.Text = "Parallel Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGetPrimes;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button ButtonGetPrimesWithTasks;
        private System.Windows.Forms.Button ButtonGetPrimesParallel;
        private System.Windows.Forms.Button ButtonPrimesParallelLockless;
    }
}

