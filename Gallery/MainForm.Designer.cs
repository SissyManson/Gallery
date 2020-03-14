namespace Gallery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbGallery = new System.Windows.Forms.PictureBox();
            this.rbImageOne = new System.Windows.Forms.RadioButton();
            this.rbImageTwo = new System.Windows.Forms.RadioButton();
            this.rbImageThree = new System.Windows.Forms.RadioButton();
            this.rbImageFour = new System.Windows.Forms.RadioButton();
            this.slideShowTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnMakeSmalleer = new System.Windows.Forms.Button();
            this.btnMakeBigger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGallery
            // 
            this.pbGallery.Image = global::Gallery.Properties.Resources._5;
            this.pbGallery.Location = new System.Drawing.Point(84, 45);
            this.pbGallery.Name = "pbGallery";
            this.pbGallery.Size = new System.Drawing.Size(478, 325);
            this.pbGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGallery.TabIndex = 0;
            this.pbGallery.TabStop = false;
            // 
            // rbImageOne
            // 
            this.rbImageOne.AutoSize = true;
            this.rbImageOne.Location = new System.Drawing.Point(647, 301);
            this.rbImageOne.Name = "rbImageOne";
            this.rbImageOne.Size = new System.Drawing.Size(77, 17);
            this.rbImageOne.TabIndex = 1;
            this.rbImageOne.TabStop = true;
            this.rbImageOne.Text = "Image One";
            this.rbImageOne.UseVisualStyleBackColor = true;
            this.rbImageOne.CheckedChanged += new System.EventHandler(this.rbImageOne_CheckedChanged);
            // 
            // rbImageTwo
            // 
            this.rbImageTwo.AutoSize = true;
            this.rbImageTwo.Location = new System.Drawing.Point(647, 324);
            this.rbImageTwo.Name = "rbImageTwo";
            this.rbImageTwo.Size = new System.Drawing.Size(78, 17);
            this.rbImageTwo.TabIndex = 2;
            this.rbImageTwo.TabStop = true;
            this.rbImageTwo.Text = "Image Two";
            this.rbImageTwo.UseVisualStyleBackColor = true;
            this.rbImageTwo.CheckedChanged += new System.EventHandler(this.rbImageTwo_CheckedChanged);
            // 
            // rbImageThree
            // 
            this.rbImageThree.AutoSize = true;
            this.rbImageThree.Location = new System.Drawing.Point(647, 347);
            this.rbImageThree.Name = "rbImageThree";
            this.rbImageThree.Size = new System.Drawing.Size(85, 17);
            this.rbImageThree.TabIndex = 3;
            this.rbImageThree.TabStop = true;
            this.rbImageThree.Text = "Image Three";
            this.rbImageThree.UseVisualStyleBackColor = true;
            this.rbImageThree.CheckedChanged += new System.EventHandler(this.rbImageThree_CheckedChanged);
            // 
            // rbImageFour
            // 
            this.rbImageFour.AutoSize = true;
            this.rbImageFour.Location = new System.Drawing.Point(647, 370);
            this.rbImageFour.Name = "rbImageFour";
            this.rbImageFour.Size = new System.Drawing.Size(78, 17);
            this.rbImageFour.TabIndex = 4;
            this.rbImageFour.TabStop = true;
            this.rbImageFour.Text = "Image Four";
            this.rbImageFour.UseVisualStyleBackColor = true;
            this.rbImageFour.CheckedChanged += new System.EventHandler(this.rbImageFour_CheckedChanged);
            // 
            // slideShowTimer
            // 
            this.slideShowTimer.Interval = 2000;
            this.slideShowTimer.Tick += new System.EventHandler(this.slideShowTimer_Tick);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(670, 45);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(75, 23);
            this.btnStartTimer.TabIndex = 5;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Location = new System.Drawing.Point(670, 74);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(75, 23);
            this.btnStopTimer.TabIndex = 6;
            this.btnStopTimer.Text = "Stop";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRight.Location = new System.Drawing.Point(568, 194);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 50);
            this.btnRight.TabIndex = 7;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeft.Location = new System.Drawing.Point(3, 194);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 50);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnMakeSmalleer
            // 
            this.btnMakeSmalleer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeSmalleer.Location = new System.Drawing.Point(181, 395);
            this.btnMakeSmalleer.Name = "btnMakeSmalleer";
            this.btnMakeSmalleer.Size = new System.Drawing.Size(75, 43);
            this.btnMakeSmalleer.TabIndex = 9;
            this.btnMakeSmalleer.Text = "-";
            this.btnMakeSmalleer.UseVisualStyleBackColor = true;
            this.btnMakeSmalleer.Click += new System.EventHandler(this.btnMakeSmalleer_Click);
            // 
            // btnMakeBigger
            // 
            this.btnMakeBigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeBigger.Location = new System.Drawing.Point(297, 395);
            this.btnMakeBigger.Name = "btnMakeBigger";
            this.btnMakeBigger.Size = new System.Drawing.Size(75, 43);
            this.btnMakeBigger.TabIndex = 10;
            this.btnMakeBigger.Text = "+";
            this.btnMakeBigger.UseVisualStyleBackColor = true;
            this.btnMakeBigger.Click += new System.EventHandler(this.btnMakeBigger_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnMakeBigger);
            this.Controls.Add(this.btnMakeSmalleer);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.rbImageFour);
            this.Controls.Add(this.rbImageThree);
            this.Controls.Add(this.rbImageTwo);
            this.Controls.Add(this.rbImageOne);
            this.Controls.Add(this.pbGallery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGallery;
        private System.Windows.Forms.RadioButton rbImageOne;
        private System.Windows.Forms.RadioButton rbImageTwo;
        private System.Windows.Forms.RadioButton rbImageThree;
        private System.Windows.Forms.RadioButton rbImageFour;
        private System.Windows.Forms.Timer slideShowTimer;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnMakeSmalleer;
        private System.Windows.Forms.Button btnMakeBigger;
    }
}

