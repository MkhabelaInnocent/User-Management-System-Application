
namespace User_Management_System_Innocent
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.fnamesT = new System.Windows.Forms.TextBox();
            this.usernameT = new System.Windows.Forms.TextBox();
            this.passwordT = new System.Windows.Forms.TextBox();
            this.registerB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "FullNames:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(91, 331);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(265, 20);
            this.registerLink.TabIndex = 3;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Login if you are a already a user";
            // 
            // fnamesT
            // 
            this.fnamesT.Location = new System.Drawing.Point(205, 169);
            this.fnamesT.Name = "fnamesT";
            this.fnamesT.Size = new System.Drawing.Size(151, 26);
            this.fnamesT.TabIndex = 4;
            // 
            // usernameT
            // 
            this.usernameT.Location = new System.Drawing.Point(205, 216);
            this.usernameT.Name = "usernameT";
            this.usernameT.Size = new System.Drawing.Size(151, 26);
            this.usernameT.TabIndex = 5;
            // 
            // passwordT
            // 
            this.passwordT.Location = new System.Drawing.Point(205, 258);
            this.passwordT.Name = "passwordT";
            this.passwordT.Size = new System.Drawing.Size(151, 26);
            this.passwordT.TabIndex = 6;
            // 
            // registerB
            // 
            this.registerB.Location = new System.Drawing.Point(206, 290);
            this.registerB.Name = "registerB";
            this.registerB.Size = new System.Drawing.Size(113, 38);
            this.registerB.TabIndex = 7;
            this.registerB.Text = "Register";
            this.registerB.UseVisualStyleBackColor = true;
            this.registerB.Click += new System.EventHandler(this.registerB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerB);
            this.Controls.Add(this.passwordT);
            this.Controls.Add(this.usernameT);
            this.Controls.Add(this.fnamesT);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.TextBox fnamesT;
        private System.Windows.Forms.TextBox usernameT;
        private System.Windows.Forms.TextBox passwordT;
        private System.Windows.Forms.Button registerB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}