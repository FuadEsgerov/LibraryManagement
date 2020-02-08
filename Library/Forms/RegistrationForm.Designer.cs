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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegistration = new System.Windows.Forms.Button();
            this.TxtRegEmail = new System.Windows.Forms.TextBox();
            this.TxtRegName = new System.Windows.Forms.TextBox();
            this.TxtRegSurname = new System.Windows.Forms.TextBox();
            this.TxtRegPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FormClosed = new System.Windows.Forms.LinkLabel();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnRegistration);
            this.panel1.Controls.Add(this.TxtPhone);
            this.panel1.Controls.Add(this.TxtRegEmail);
            this.panel1.Controls.Add(this.TxtRegName);
            this.panel1.Controls.Add(this.TxtRegSurname);
            this.panel1.Controls.Add(this.TxtRegPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(174, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 410);
            this.panel1.TabIndex = 1;
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
            this.label4.Location = new System.Drawing.Point(7, 205);
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
            this.label3.Location = new System.Drawing.Point(7, 243);
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
            this.BtnRegistration.Location = new System.Drawing.Point(104, 324);
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
            this.TxtRegEmail.Location = new System.Drawing.Point(104, 167);
            this.TxtRegEmail.Name = "TxtRegEmail";
            this.TxtRegEmail.Size = new System.Drawing.Size(165, 23);
            this.TxtRegEmail.TabIndex = 16;
            // 
            // TxtRegName
            // 
            this.TxtRegName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRegName.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegName.Location = new System.Drawing.Point(104, 87);
            this.TxtRegName.Name = "TxtRegName";
            this.TxtRegName.Size = new System.Drawing.Size(165, 23);
            this.TxtRegName.TabIndex = 15;
            // 
            // TxtRegSurname
            // 
            this.TxtRegSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRegSurname.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegSurname.Location = new System.Drawing.Point(104, 127);
            this.TxtRegSurname.Name = "TxtRegSurname";
            this.TxtRegSurname.Size = new System.Drawing.Size(165, 23);
            this.TxtRegSurname.TabIndex = 15;
            // 
            // TxtRegPassword
            // 
            this.TxtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRegPassword.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegPassword.Location = new System.Drawing.Point(104, 248);
            this.TxtRegPassword.Name = "TxtRegPassword";
            this.TxtRegPassword.Size = new System.Drawing.Size(165, 23);
            this.TxtRegPassword.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(7, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(7, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Surname";
            // 
            // FormClosed
            // 
            this.FormClosed.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.FormClosed.AutoSize = true;
            this.FormClosed.BackColor = System.Drawing.Color.Transparent;
            this.FormClosed.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.FormClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormClosed.LinkColor = System.Drawing.Color.White;
            this.FormClosed.Location = new System.Drawing.Point(667, 9);
            this.FormClosed.Name = "FormClosed";
            this.FormClosed.Size = new System.Drawing.Size(21, 20);
            this.FormClosed.TabIndex = 2;
            this.FormClosed.TabStop = true;
            this.FormClosed.Text = "X";
            this.FormClosed.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormClosed.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FormClosed_LinkClicked);
            // 
            // TxtPhone
            // 
            this.TxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPhone.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(104, 210);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(165, 23);
            this.TxtPhone.TabIndex = 16;
          
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(7, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phone ";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.FormClosed);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegistration;
        private System.Windows.Forms.TextBox TxtRegEmail;
        private System.Windows.Forms.TextBox TxtRegPassword;
        private System.Windows.Forms.TextBox TxtRegName;
        private System.Windows.Forms.TextBox TxtRegSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel FormClosed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPhone;
    }
}