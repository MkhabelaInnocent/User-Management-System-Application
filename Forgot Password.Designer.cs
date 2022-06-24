
namespace User_Management_System_Innocent
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            this.label1 = new System.Windows.Forms.Label();
            this.showpasswordB = new System.Windows.Forms.Button();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.usernameT = new System.Windows.Forms.TextBox();
            this.loginB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // showpasswordB
            // 
            this.showpasswordB.Location = new System.Drawing.Point(232, 232);
            this.showpasswordB.Name = "showpasswordB";
            this.showpasswordB.Size = new System.Drawing.Size(186, 35);
            this.showpasswordB.TabIndex = 1;
            this.showpasswordB.Text = "Show Password";
            this.showpasswordB.UseVisualStyleBackColor = true;
            this.showpasswordB.Click += new System.EventHandler(this.showpasswordB_Click);
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(166, 312);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(252, 20);
            this.registerLink.TabIndex = 2;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Register if you are not a usr..!!";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // usernameT
            // 
            this.usernameT.Location = new System.Drawing.Point(232, 180);
            this.usernameT.Name = "usernameT";
            this.usernameT.Size = new System.Drawing.Size(186, 26);
            this.usernameT.TabIndex = 3;
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(135, 232);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 35);
            this.loginB.TabIndex = 4;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.usernameT);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.showpasswordB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forgot_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot_Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showpasswordB;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.TextBox usernameT;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}