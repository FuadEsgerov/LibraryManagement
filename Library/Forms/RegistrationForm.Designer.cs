namespace Library.Forms
{
    partial class RegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxUsertype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegistration = new System.Windows.Forms.Button();
            this.TxtRegEmail = new System.Windows.Forms.TextBox();
            this.TxtRegFullname = new System.Windows.Forms.TextBox();
            this.TxtRegUsername = new System.Windows.Forms.TextBox();
            this.TxtRegPassword = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBoxUsertype);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnRegistration);
            this.panel1.Controls.Add(this.TxtRegEmail);
            this.panel1.Controls.Add(this.TxtRegFullname);
            this.panel1.Controls.Add(this.TxtRegUsername);
            this.panel1.Controls.Add(this.TxtRegPassword);
            this.panel1.Location = new System.Drawing.Point(144, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 425);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxUsertype
            // 
            this.comboBoxUsertype.Font = new System.Drawing.Font("Segoe Print", 8.5F);
            this.comboBoxUsertype.FormattingEnabled = true;
            this.comboBoxUsertype.Items.AddRange(new object[] {
            "Moderator",
            "Admin"});
            this.comboBoxUsertype.Location = new System.Drawing.Point(143, 252);
            this.comboBoxUsertype.Name = "comboBoxUsertype";
            this.comboBoxUsertype.Size = new System.Drawing.Size(167, 27);
            this.comboBoxUsertype.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(8, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Select User Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(7, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fullname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(7, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(10, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistration.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistration.Location = new System.Drawing.Point(122, 323);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(172, 43);
            this.BtnRegistration.TabIndex = 17;
            this.BtnRegistration.Text = "Registration";
            this.BtnRegistration.UseVisualStyleBackColor = true;
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // TxtRegEmail
            // 
            this.TxtRegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRegEmail.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegEmail.Location = new System.Drawing.Point(145, 162);
            this.TxtRegEmail.Name = "TxtRegEmail";
            this.TxtRegEmail.Size = new System.Drawing.Size(165, 23);
            this.TxtRegEmail.TabIndex = 16;
            // 
            // TxtRegFullname
            // 
            this.TxtRegFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRegFullname.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegFullname.Location = new System.Drawing.Point(145, 82);
            this.TxtRegFullname.Name = "TxtRegFullname";
            this.TxtRegFullname.Size = new System.Drawing.Size(165, 23);
            this.TxtRegFullname.TabIndex = 15;
            // 
            // TxtRegUsername
            // 
            this.TxtRegUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRegUsername.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegUsername.Location = new System.Drawing.Point(145, 122);
            this.TxtRegUsername.Name = "TxtRegUsername";
            this.TxtRegUsername.Size = new System.Drawing.Size(165, 23);
            this.TxtRegUsername.TabIndex = 15;
            // 
            // TxtRegPassword
            // 
            this.TxtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRegPassword.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegPassword.Location = new System.Drawing.Point(145, 207);
            this.TxtRegPassword.Name = "TxtRegPassword";
            this.TxtRegPassword.Size = new System.Drawing.Size(165, 23);
            this.TxtRegPassword.TabIndex = 16;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.Location = new System.Drawing.Point(663, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegistration;
        private System.Windows.Forms.TextBox TxtRegPassword;
        private System.Windows.Forms.TextBox TxtRegFullname;
        private System.Windows.Forms.TextBox TxtRegUsername;
        private System.Windows.Forms.TextBox TxtRegEmail;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ComboBox comboBoxUsertype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}