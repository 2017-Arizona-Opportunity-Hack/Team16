namespace MainHack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sign_up_button = new System.Windows.Forms.Button();
            this.constant_contact = new System.Windows.Forms.Button();
            this.Analytics = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sign_up_button
            // 
            this.sign_up_button.Location = new System.Drawing.Point(446, 97);
            this.sign_up_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Size = new System.Drawing.Size(380, 62);
            this.sign_up_button.TabIndex = 0;
            this.sign_up_button.Text = "Sign Up";
            this.sign_up_button.UseVisualStyleBackColor = true;
            this.sign_up_button.Click += new System.EventHandler(this.sign_up_button_Click);
            // 
            // constant_contact
            // 
            this.constant_contact.Location = new System.Drawing.Point(446, 205);
            this.constant_contact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.constant_contact.Name = "constant_contact";
            this.constant_contact.Size = new System.Drawing.Size(380, 64);
            this.constant_contact.TabIndex = 1;
            this.constant_contact.Text = "Enter Constant Contact Information";
            this.constant_contact.UseVisualStyleBackColor = true;
            this.constant_contact.Click += new System.EventHandler(this.constant_contact_Click);
            // 
            // Analytics
            // 
            this.Analytics.Location = new System.Drawing.Point(446, 316);
            this.Analytics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Analytics.Name = "Analytics";
            this.Analytics.Size = new System.Drawing.Size(380, 64);
            this.Analytics.TabIndex = 2;
            this.Analytics.Text = "Perform Analytics";
            this.Analytics.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Analytics);
            this.Controls.Add(this.constant_contact);
            this.Controls.Add(this.sign_up_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Data Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sign_up_button;
        private System.Windows.Forms.Button constant_contact;
        private System.Windows.Forms.Button Analytics;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

