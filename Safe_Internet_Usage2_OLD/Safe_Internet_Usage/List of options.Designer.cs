namespace Safe_Internet_Usage
{
    partial class List_of_options
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
            this.btnHttps = new System.Windows.Forms.Button();
            this.Securitycertificate = new System.Windows.Forms.Button();
            this.btnonlinepayment = new System.Windows.Forms.Button();
            this.btnLogoutSignoff = new System.Windows.Forms.Button();
            this.btnVirtualKeyboard = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHttps
            // 
            this.btnHttps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHttps.Location = new System.Drawing.Point(7, 93);
            this.btnHttps.Name = "btnHttps";
            this.btnHttps.Size = new System.Drawing.Size(95, 31);
            this.btnHttps.TabIndex = 0;
            this.btnHttps.Text = "Https";
            this.btnHttps.UseVisualStyleBackColor = true;
            this.btnHttps.Click += new System.EventHandler(this.btnHttps_Click);
            // 
            // Securitycertificate
            // 
            this.Securitycertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Securitycertificate.Location = new System.Drawing.Point(133, 62);
            this.Securitycertificate.Name = "Securitycertificate";
            this.Securitycertificate.Size = new System.Drawing.Size(109, 30);
            this.Securitycertificate.TabIndex = 1;
            this.Securitycertificate.Text = "Security certificate";
            this.Securitycertificate.UseVisualStyleBackColor = true;
            this.Securitycertificate.Click += new System.EventHandler(this.Securitycertificate_Click);
            // 
            // btnonlinepayment
            // 
            this.btnonlinepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnonlinepayment.Location = new System.Drawing.Point(65, 159);
            this.btnonlinepayment.Name = "btnonlinepayment";
            this.btnonlinepayment.Size = new System.Drawing.Size(126, 30);
            this.btnonlinepayment.TabIndex = 2;
            this.btnonlinepayment.Text = "online payment";
            this.btnonlinepayment.UseVisualStyleBackColor = true;
            this.btnonlinepayment.Click += new System.EventHandler(this.btnonlinepayment_Click);
            // 
            // btnLogoutSignoff
            // 
            this.btnLogoutSignoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutSignoff.Location = new System.Drawing.Point(212, 159);
            this.btnLogoutSignoff.Name = "btnLogoutSignoff";
            this.btnLogoutSignoff.Size = new System.Drawing.Size(131, 30);
            this.btnLogoutSignoff.TabIndex = 3;
            this.btnLogoutSignoff.Text = "Log out / sign off";
            this.btnLogoutSignoff.UseVisualStyleBackColor = true;
            this.btnLogoutSignoff.Click += new System.EventHandler(this.btnLogoutSignoff_Click);
            // 
            // btnVirtualKeyboard
            // 
            this.btnVirtualKeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirtualKeyboard.Location = new System.Drawing.Point(254, 93);
            this.btnVirtualKeyboard.Name = "btnVirtualKeyboard";
            this.btnVirtualKeyboard.Size = new System.Drawing.Size(134, 31);
            this.btnVirtualKeyboard.TabIndex = 4;
            this.btnVirtualKeyboard.Text = "Virtual Keyboard";
            this.btnVirtualKeyboard.UseVisualStyleBackColor = true;
            this.btnVirtualKeyboard.Click += new System.EventHandler(this.btnVirtualKeyboard_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(286, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 38);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Safe_Internet_Usage.Properties.Resources.doors_options;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 280);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // List_of_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 275);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnVirtualKeyboard);
            this.Controls.Add(this.btnLogoutSignoff);
            this.Controls.Add(this.btnonlinepayment);
            this.Controls.Add(this.Securitycertificate);
            this.Controls.Add(this.btnHttps);
            this.Controls.Add(this.pictureBox1);
            this.Name = "List_of_options";
            this.ShowIcon = false;
            this.Text = "List_of_options";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHttps;
        private System.Windows.Forms.Button Securitycertificate;
        private System.Windows.Forms.Button btnonlinepayment;
        private System.Windows.Forms.Button btnLogoutSignoff;
        private System.Windows.Forms.Button btnVirtualKeyboard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}