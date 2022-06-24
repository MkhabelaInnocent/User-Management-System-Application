
namespace User_Management_System_Innocent
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.usernameT = new System.Windows.Forms.TextBox();
            this.passwordT = new System.Windows.Forms.TextBox();
            this.fpasswordB = new System.Windows.Forms.Button();
            this.loginB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(100, 322);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(278, 20);
            this.registerLink.TabIndex = 3;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Register if you are a new user....!!";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // usernameT
            // 
            this.usernameT.Location = new System.Drawing.Point(203, 169);
            this.usernameT.Name = "usernameT";
            this.usernameT.Size = new System.Drawing.Size(175, 26);
            this.usernameT.TabIndex = 4;
            // 
            // passwordT
            // 
            this.passwordT.Location = new System.Drawing.Point(203, 216);
            this.passwordT.Name = "passwordT";
            this.passwordT.Size = new System.Drawing.Size(175, 26);
            this.passwordT.TabIndex = 5;
            this.passwordT.UseSystemPasswordChar = true;
            // 
            // fpasswordB
            // 
            this.fpasswordB.Location = new System.Drawing.Point(86, 258);
            this.fpasswordB.Name = "fpasswordB";
            this.fpasswordB.Size = new System.Drawing.Size(192, 37);
            this.fpasswordB.TabIndex = 6;
            this.fpasswordB.Text = "Forgotten Password";
            this.fpasswordB.UseVisualStyleBackColor = true;
            this.fpasswordB.Click += new System.EventHandler(this.fpasswordB_Click);
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(313, 258);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(65, 37);
            this.loginB.TabIndex = 7;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.fpasswordB);
            this.Controls.Add(this.passwordT);
            this.Controls.Add(this.usernameT);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.TextBox usernameT;
        private System.Windows.Forms.TextBox passwordT;
        private System.Windows.Forms.Button fpasswordB;
        private System.Windows.Forms.Button loginB;
    }
}

