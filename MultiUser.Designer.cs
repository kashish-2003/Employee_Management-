namespace FirstEmployeeDesktop
{
    partial class MultiUser
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncheckin = new System.Windows.Forms.Button();
            this.btncheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblcheckin = new System.Windows.Forms.Label();
            this.lblcheckout = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.textCheckin = new System.Windows.Forms.TextBox();
            this.textcheckout = new System.Windows.Forms.TextBox();
            this.textduration = new System.Windows.Forms.TextBox();
            this.btnCross = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textdate = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::FirstEmployeeDesktop.Properties.Resources.checkout_icon;
            this.pictureBox2.Location = new System.Drawing.Point(674, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstEmployeeDesktop.Properties.Resources.checkin_icon;
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btncheckin
            // 
            this.btncheckin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btncheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckin.Location = new System.Drawing.Point(190, 121);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(167, 38);
            this.btncheckin.TabIndex = 8;
            this.btncheckin.Text = "Check in";
            this.btncheckin.UseVisualStyleBackColor = false;
            this.btncheckin.Click += new System.EventHandler(this.btncheckin_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btncheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckout.Location = new System.Drawing.Point(648, 121);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(167, 38);
            this.btncheckout.TabIndex = 9;
            this.btncheckout.Text = "Check out";
            this.btncheckout.UseVisualStyleBackColor = false;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "My Attendance";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(306, 245);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(96, 36);
            this.lblname.TabIndex = 11;
            this.lblname.Text = "Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(325, 316);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 36);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            // 
            // lblcheckin
            // 
            this.lblcheckin.AutoSize = true;
            this.lblcheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckin.Location = new System.Drawing.Point(282, 399);
            this.lblcheckin.Name = "lblcheckin";
            this.lblcheckin.Size = new System.Drawing.Size(139, 36);
            this.lblcheckin.TabIndex = 13;
            this.lblcheckin.Text = "Check in";
            // 
            // lblcheckout
            // 
            this.lblcheckout.AutoSize = true;
            this.lblcheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckout.Location = new System.Drawing.Point(272, 499);
            this.lblcheckout.Name = "lblcheckout";
            this.lblcheckout.Size = new System.Drawing.Size(158, 36);
            this.lblcheckout.TabIndex = 14;
            this.lblcheckout.Text = "Check out";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(285, 559);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(136, 36);
            this.lblDuration.TabIndex = 15;
            this.lblDuration.Text = "Duration";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(536, 248);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 35);
            this.txtName.TabIndex = 16;
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.LightSlateGray;
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(536, 319);
            this.textId.Multiline = true;
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(216, 35);
            this.textId.TabIndex = 17;
            // 
            // textCheckin
            // 
            this.textCheckin.BackColor = System.Drawing.Color.LightSlateGray;
            this.textCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCheckin.Location = new System.Drawing.Point(536, 383);
            this.textCheckin.Multiline = true;
            this.textCheckin.Name = "textCheckin";
            this.textCheckin.Size = new System.Drawing.Size(216, 64);
            this.textCheckin.TabIndex = 18;
            this.textCheckin.TextChanged += new System.EventHandler(this.textCheckin_TextChanged);
            // 
            // textcheckout
            // 
            this.textcheckout.BackColor = System.Drawing.Color.LightSlateGray;
            this.textcheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcheckout.Location = new System.Drawing.Point(536, 483);
            this.textcheckout.Multiline = true;
            this.textcheckout.Name = "textcheckout";
            this.textcheckout.Size = new System.Drawing.Size(216, 70);
            this.textcheckout.TabIndex = 19;
            // 
            // textduration
            // 
            this.textduration.BackColor = System.Drawing.Color.LightSlateGray;
            this.textduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textduration.Location = new System.Drawing.Point(536, 573);
            this.textduration.Multiline = true;
            this.textduration.Name = "textduration";
            this.textduration.Size = new System.Drawing.Size(216, 35);
            this.textduration.TabIndex = 20;
            this.textduration.TextChanged += new System.EventHandler(this.textduration_TextChanged);
            // 
            // btnCross
            // 
            this.btnCross.BackColor = System.Drawing.Color.Red;
            this.btnCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCross.Location = new System.Drawing.Point(971, -1);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(56, 51);
            this.btnCross.TabIndex = 21;
            this.btnCross.Text = "X";
            this.btnCross.UseVisualStyleBackColor = false;
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // textdate
            // 
            this.textdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.textdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdate.Location = new System.Drawing.Point(536, 628);
            this.textdate.Multiline = true;
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(216, 35);
            this.textdate.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(925, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 51);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MultiUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1028, 690);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCross);
            this.Controls.Add(this.textduration);
            this.Controls.Add(this.textcheckout);
            this.Controls.Add(this.textCheckin);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblcheckout);
            this.Controls.Add(this.lblcheckin);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncheckout);
            this.Controls.Add(this.btncheckin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MultiUser";
            this.Text = "MultiUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btncheckin;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblcheckin;
        private System.Windows.Forms.Label lblcheckout;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textCheckin;
        private System.Windows.Forms.TextBox textcheckout;
        private System.Windows.Forms.TextBox textduration;
        private System.Windows.Forms.Button btnCross;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textdate;
        private System.Windows.Forms.Button btnBack;
    }
}