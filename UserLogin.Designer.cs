namespace FirstEmployeeDesktop
{
    partial class UserLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCross = new System.Windows.Forms.Button();
            this.lbUserIduser = new System.Windows.Forms.Label();
            this.lblPasswordUserId = new System.Windows.Forms.Label();
            this.txtUseridpassword = new System.Windows.Forms.TextBox();
            this.textuseriduser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.AdminLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kallwik Employee Management System";
            // 
            // btnCross
            // 
            this.btnCross.BackColor = System.Drawing.Color.Red;
            this.btnCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCross.Location = new System.Drawing.Point(909, 0);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(56, 51);
            this.btnCross.TabIndex = 4;
            this.btnCross.Text = "X";
            this.btnCross.UseVisualStyleBackColor = false;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // lbUserIduser
            // 
            this.lbUserIduser.AutoSize = true;
            this.lbUserIduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIduser.Location = new System.Drawing.Point(143, 168);
            this.lbUserIduser.Name = "lbUserIduser";
            this.lbUserIduser.Size = new System.Drawing.Size(118, 36);
            this.lbUserIduser.TabIndex = 7;
            this.lbUserIduser.Text = "User Id";
            // 
            // lblPasswordUserId
            // 
            this.lblPasswordUserId.AutoSize = true;
            this.lblPasswordUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordUserId.Location = new System.Drawing.Point(143, 275);
            this.lblPasswordUserId.Name = "lblPasswordUserId";
            this.lblPasswordUserId.Size = new System.Drawing.Size(155, 36);
            this.lblPasswordUserId.TabIndex = 8;
            this.lblPasswordUserId.Text = "Password";
            // 
            // txtUseridpassword
            // 
            this.txtUseridpassword.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtUseridpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseridpassword.Location = new System.Drawing.Point(372, 276);
            this.txtUseridpassword.Multiline = true;
            this.txtUseridpassword.Name = "txtUseridpassword";
            this.txtUseridpassword.Size = new System.Drawing.Size(216, 35);
            this.txtUseridpassword.TabIndex = 9;
            // 
            // textuseriduser
            // 
            this.textuseriduser.BackColor = System.Drawing.Color.LightSlateGray;
            this.textuseriduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuseriduser.Location = new System.Drawing.Point(372, 171);
            this.textuseriduser.Multiline = true;
            this.textuseriduser.Name = "textuseriduser";
            this.textuseriduser.Size = new System.Drawing.Size(216, 35);
            this.textuseriduser.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(289, 389);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(167, 38);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(541, 390);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(167, 37);
            this.btnClr.TabIndex = 12;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // AdminLoginBtn
            // 
            this.AdminLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginBtn.Location = new System.Drawing.Point(746, 493);
            this.AdminLoginBtn.Name = "AdminLoginBtn";
            this.AdminLoginBtn.Size = new System.Drawing.Size(167, 38);
            this.AdminLoginBtn.TabIndex = 13;
            this.AdminLoginBtn.Text = "Admin Login";
            this.AdminLoginBtn.UseVisualStyleBackColor = true;
            this.AdminLoginBtn.Click += new System.EventHandler(this.AdminLoginBtn_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(961, 562);
            this.Controls.Add(this.AdminLoginBtn);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textuseriduser);
            this.Controls.Add(this.txtUseridpassword);
            this.Controls.Add(this.lblPasswordUserId);
            this.Controls.Add(this.lbUserIduser);
            this.Controls.Add(this.btnCross);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.Label lbUserIduser;
        private System.Windows.Forms.Label lblPasswordUserId;
        private System.Windows.Forms.TextBox txtUseridpassword;
        private System.Windows.Forms.TextBox textuseriduser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button AdminLoginBtn;
    }
}