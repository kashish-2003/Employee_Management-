namespace FirstEmployeeDesktop
{
    partial class ViewAttendance
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
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.textEmployeeId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblcheckin = new System.Windows.Forms.Label();
            this.lblcheckout = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textCheckin = new System.Windows.Forms.TextBox();
            this.textcheckout = new System.Windows.Forms.TextBox();
            this.textduration = new System.Windows.Forms.TextBox();
            this.textdate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Attendance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(654, 123);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(159, 29);
            this.lblEmployeeId.TabIndex = 13;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // textEmployeeId
            // 
            this.textEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmployeeId.Location = new System.Drawing.Point(846, 123);
            this.textEmployeeId.Multiline = true;
            this.textEmployeeId.Name = "textEmployeeId";
            this.textEmployeeId.Size = new System.Drawing.Size(174, 29);
            this.textEmployeeId.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(693, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(868, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 45);
            this.button3.TabIndex = 24;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(128, 237);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 36);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "Id";
            // 
            // lblcheckin
            // 
            this.lblcheckin.AutoSize = true;
            this.lblcheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckin.Location = new System.Drawing.Point(128, 309);
            this.lblcheckin.Name = "lblcheckin";
            this.lblcheckin.Size = new System.Drawing.Size(139, 36);
            this.lblcheckin.TabIndex = 26;
            this.lblcheckin.Text = "Check in";
            // 
            // lblcheckout
            // 
            this.lblcheckout.AutoSize = true;
            this.lblcheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckout.Location = new System.Drawing.Point(128, 423);
            this.lblcheckout.Name = "lblcheckout";
            this.lblcheckout.Size = new System.Drawing.Size(158, 36);
            this.lblcheckout.TabIndex = 27;
            this.lblcheckout.Text = "Check out";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(131, 510);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(136, 36);
            this.lblDuration.TabIndex = 28;
            this.lblDuration.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date";
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.LightSlateGray;
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(340, 238);
            this.textId.Multiline = true;
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(216, 35);
            this.textId.TabIndex = 30;
            // 
            // textCheckin
            // 
            this.textCheckin.BackColor = System.Drawing.Color.LightSlateGray;
            this.textCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCheckin.Location = new System.Drawing.Point(340, 297);
            this.textCheckin.Multiline = true;
            this.textCheckin.Name = "textCheckin";
            this.textCheckin.Size = new System.Drawing.Size(216, 64);
            this.textCheckin.TabIndex = 31;
            // 
            // textcheckout
            // 
            this.textcheckout.BackColor = System.Drawing.Color.LightSlateGray;
            this.textcheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcheckout.Location = new System.Drawing.Point(340, 406);
            this.textcheckout.Multiline = true;
            this.textcheckout.Name = "textcheckout";
            this.textcheckout.Size = new System.Drawing.Size(216, 70);
            this.textcheckout.TabIndex = 32;
            // 
            // textduration
            // 
            this.textduration.BackColor = System.Drawing.Color.LightSlateGray;
            this.textduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textduration.Location = new System.Drawing.Point(340, 511);
            this.textduration.Multiline = true;
            this.textduration.Name = "textduration";
            this.textduration.Size = new System.Drawing.Size(216, 35);
            this.textduration.TabIndex = 33;
            // 
            // textdate
            // 
            this.textdate.BackColor = System.Drawing.Color.LightSlateGray;
            this.textdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdate.Location = new System.Drawing.Point(340, 577);
            this.textdate.Multiline = true;
            this.textdate.Name = "textdate";
            this.textdate.Size = new System.Drawing.Size(216, 35);
            this.textdate.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(748, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 77);
            this.button2.TabIndex = 35;
            this.button2.Text = "Monthly Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1000, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 51);
            this.button4.TabIndex = 36;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(953, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 51);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1057, 644);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textdate);
            this.Controls.Add(this.textduration);
            this.Controls.Add(this.textcheckout);
            this.Controls.Add(this.textCheckin);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblcheckout);
            this.Controls.Add(this.lblcheckin);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEmployeeId);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAttendance";
            this.Text = "ViewAttendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox textEmployeeId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblcheckin;
        private System.Windows.Forms.Label lblcheckout;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textCheckin;
        private System.Windows.Forms.TextBox textcheckout;
        private System.Windows.Forms.TextBox textduration;
        private System.Windows.Forms.TextBox textdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBack;
    }
}