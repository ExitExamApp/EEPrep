namespace EEPrep
{
    partial class WelcomingScreen
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
            this.WelcomingLabel = new System.Windows.Forms.Label();
            this.WelcomingPictureBox = new System.Windows.Forms.PictureBox();
            this.WelcomingLabel2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WelcomingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomingLabel
            // 
            this.WelcomingLabel.AutoSize = true;
            this.WelcomingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomingLabel.Location = new System.Drawing.Point(12, 25);
            this.WelcomingLabel.Name = "WelcomingLabel";
            this.WelcomingLabel.Size = new System.Drawing.Size(331, 42);
            this.WelcomingLabel.TabIndex = 1;
            this.WelcomingLabel.Text = "Welcome To Your";
            this.WelcomingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WelcomingPictureBox
            // 
            this.WelcomingPictureBox.Image = global::EEPrep.Properties.Resources.EEPrepLogo;
            this.WelcomingPictureBox.Location = new System.Drawing.Point(19, 86);
            this.WelcomingPictureBox.Name = "WelcomingPictureBox";
            this.WelcomingPictureBox.Size = new System.Drawing.Size(310, 200);
            this.WelcomingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WelcomingPictureBox.TabIndex = 2;
            this.WelcomingPictureBox.TabStop = false;
            // 
            // WelcomingLabel2
            // 
            this.WelcomingLabel2.AutoSize = true;
            this.WelcomingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomingLabel2.Location = new System.Drawing.Point(16, 294);
            this.WelcomingLabel2.Name = "WelcomingLabel2";
            this.WelcomingLabel2.Size = new System.Drawing.Size(466, 42);
            this.WelcomingLabel2.TabIndex = 3;
            this.WelcomingLabel2.Text = "Exit Exam Preparation By";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EEPrep.Properties.Resources.ARClogo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StudentButton
            // 
            this.StudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentButton.Location = new System.Drawing.Point(793, 220);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(126, 38);
            this.StudentButton.TabIndex = 5;
            this.StudentButton.Text = "Student Login";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Location = new System.Drawing.Point(793, 339);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(126, 38);
            this.AdminButton.TabIndex = 6;
            this.AdminButton.Text = "Admin Login";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // WelcomingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 510);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WelcomingLabel2);
            this.Controls.Add(this.WelcomingPictureBox);
            this.Controls.Add(this.WelcomingLabel);
            this.Name = "WelcomingScreen";
            this.Text = "WelcomingScreen";
            this.Load += new System.EventHandler(this.WelcomingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WelcomingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomingLabel;
        private System.Windows.Forms.PictureBox WelcomingPictureBox;
        private System.Windows.Forms.Label WelcomingLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button AdminButton;
    }
}