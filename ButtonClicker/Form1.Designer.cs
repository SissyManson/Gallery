namespace ButtonClicker
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
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(12, 71);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(70, 102);
            this.btnIncrement.TabIndex = 0;
            this.btnIncrement.Text = "Click";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(279, 71);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 102);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(161, 127);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(35, 13);
            this.lblCounter.TabIndex = 2;
            this.lblCounter.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 301);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnIncrement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCounter;
    }
}

