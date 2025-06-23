namespace FirstEmployeeDesktop
{
    partial class View
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEmpid = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpGender = new System.Windows.Forms.Label();
            this.lblEmpDept = new System.Windows.Forms.Label();
            this.textEmpId = new System.Windows.Forms.TextBox();
            this.textEmpName = new System.Windows.Forms.TextBox();
            this.textEmployeeId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "VIEW ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(951, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 51);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search By Id";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(538, 158);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(159, 29);
            this.lblEmployeeId.TabIndex = 12;
            this.lblEmployeeId.Text = "Employee Id";
            this.lblEmployeeId.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEmpid
            // 
            this.lblEmpid.AutoSize = true;
            this.lblEmpid.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblEmpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpid.Location = new System.Drawing.Point(18, 275);
            this.lblEmpid.Name = "lblEmpid";
            this.lblEmpid.Size = new System.Drawing.Size(159, 29);
            this.lblEmpid.TabIndex = 13;
            this.lblEmpid.Text = "Employee Id";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(18, 355);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(206, 29);
            this.lblEmpName.TabIndex = 14;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lblEmpGender
            // 
            this.lblEmpGender.AutoSize = true;
            this.lblEmpGender.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblEmpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpGender.Location = new System.Drawing.Point(18, 430);
            this.lblEmpGender.Name = "lblEmpGender";
            this.lblEmpGender.Size = new System.Drawing.Size(224, 29);
            this.lblEmpGender.TabIndex = 15;
            this.lblEmpGender.Text = "Employee Gender";
            // 
            // lblEmpDept
            // 
            this.lblEmpDept.AutoSize = true;
            this.lblEmpDept.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblEmpDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDept.Location = new System.Drawing.Point(17, 503);
            this.lblEmpDept.Name = "lblEmpDept";
            this.lblEmpDept.Size = new System.Drawing.Size(272, 29);
            this.lblEmpDept.TabIndex = 16;
            this.lblEmpDept.Text = "Employee Department";
            // 
            // textEmpId
            // 
            this.textEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpId.Location = new System.Drawing.Point(321, 275);
            this.textEmpId.Multiline = true;
            this.textEmpId.Name = "textEmpId";
            this.textEmpId.Size = new System.Drawing.Size(197, 29);
            this.textEmpId.TabIndex = 17;
            // 
            // textEmpName
            // 
            this.textEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpName.Location = new System.Drawing.Point(321, 355);
            this.textEmpName.Multiline = true;
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(197, 29);
            this.textEmpName.TabIndex = 18;
            // 
            // textEmployeeId
            // 
            this.textEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmployeeId.Location = new System.Drawing.Point(777, 158);
            this.textEmployeeId.Multiline = true;
            this.textEmployeeId.Name = "textEmployeeId";
            this.textEmployeeId.Size = new System.Drawing.Size(174, 29);
            this.textEmployeeId.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(577, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(777, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 45);
            this.button3.TabIndex = 23;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(895, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 51);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(457, 595);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 38);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(605, 595);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 38);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.LightSlateGray;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBoxGender.Location = new System.Drawing.Point(321, 437);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(197, 24);
            this.comboBoxGender.TabIndex = 27;
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.BackColor = System.Drawing.Color.LightSlateGray;
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Items.AddRange(new object[] {
            "HR",
            "Finance",
            "Junior Developer",
            "Senior Developer",
            "Manager"});
            this.comboBoxDept.Location = new System.Drawing.Point(321, 508);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(197, 24);
            this.comboBoxDept.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(2, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 38);
            this.button4.TabIndex = 29;
            this.button4.Text = "Employees";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(749, 595);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 38);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstEmployeeDesktop.Properties.Resources.viewicon_jpeg;
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(653, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 81);
            this.button5.TabIndex = 31;
            this.button5.Text = "View Attendance";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEmployeeId);
            this.Controls.Add(this.textEmpName);
            this.Controls.Add(this.textEmpId);
            this.Controls.Add(this.lblEmpDept);
            this.Controls.Add(this.lblEmpGender);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpid);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View";
            this.Text = "View";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblEmpid;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpGender;
        private System.Windows.Forms.Label lblEmpDept;
        private System.Windows.Forms.TextBox textEmpId;
        private System.Windows.Forms.TextBox textEmpName;
        private System.Windows.Forms.TextBox textEmployeeId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button5;
    }
}