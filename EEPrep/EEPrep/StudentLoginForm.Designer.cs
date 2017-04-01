namespace EEPrep
{
    partial class StudentLoginForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.StuLoginNextButton = new System.Windows.Forms.Button();
            this.atLabel = new System.Windows.Forms.Label();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(319, 162);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(182, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(319, 225);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(182, 20);
            this.EmailTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(238, 159);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 23);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(238, 219);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(75, 23);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // StuLoginNextButton
            // 
            this.StuLoginNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StuLoginNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuLoginNextButton.Location = new System.Drawing.Point(371, 296);
            this.StuLoginNextButton.Name = "StuLoginNextButton";
            this.StuLoginNextButton.Size = new System.Drawing.Size(96, 37);
            this.StuLoginNextButton.TabIndex = 4;
            this.StuLoginNextButton.Text = "Next";
            this.StuLoginNextButton.UseVisualStyleBackColor = false;
            this.StuLoginNextButton.Click += new System.EventHandler(this.StuLoginNextButton_Click);
            // 
            // atLabel
            // 
            this.atLabel.AutoSize = true;
            this.atLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atLabel.Location = new System.Drawing.Point(507, 227);
            this.atLabel.Name = "atLabel";
            this.atLabel.Size = new System.Drawing.Size(24, 18);
            this.atLabel.TabIndex = 5;
            this.atLabel.Text = "@";
            // 
            // domainTextBox
            // 
            this.domainTextBox.Location = new System.Drawing.Point(537, 225);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(146, 20);
            this.domainTextBox.TabIndex = 8;
            // 
            // StudentLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.domainTextBox);
            this.Controls.Add(this.atLabel);
            this.Controls.Add(this.StuLoginNextButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "StudentLoginForm";
            this.Text = "Student Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button StuLoginNextButton;
        private System.Windows.Forms.Label atLabel;
        private System.Windows.Forms.TextBox domainTextBox;
    }
}

