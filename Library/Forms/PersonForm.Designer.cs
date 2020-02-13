namespace Library.Forms
{
    partial class PersonForm
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
            this.DgvUserCrud = new System.Windows.Forms.DataGridView();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TbPhonenumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPersonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserCrud)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUserCrud
            // 
            this.DgvUserCrud.AllowUserToAddRows = false;
            this.DgvUserCrud.AllowUserToDeleteRows = false;
            this.DgvUserCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUserCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUserCrud.Location = new System.Drawing.Point(266, 85);
            this.DgvUserCrud.Margin = new System.Windows.Forms.Padding(2);
            this.DgvUserCrud.Name = "DgvUserCrud";
            this.DgvUserCrud.ReadOnly = true;
            this.DgvUserCrud.RowHeadersWidth = 51;
            this.DgvUserCrud.RowTemplate.Height = 24;
            this.DgvUserCrud.Size = new System.Drawing.Size(560, 373);
            this.DgvUserCrud.TabIndex = 26;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(59, 421);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(78, 37);
            this.BtnUpdate.TabIndex = 25;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(59, 379);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(78, 37);
            this.BtnAdd.TabIndex = 24;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // TbPhonenumber
            // 
            this.TbPhonenumber.Location = new System.Drawing.Point(59, 339);
            this.TbPhonenumber.Margin = new System.Windows.Forms.Padding(2);
            this.TbPhonenumber.Name = "TbPhonenumber";
            this.TbPhonenumber.Size = new System.Drawing.Size(98, 20);
            this.TbPhonenumber.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phonenumber:";
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(59, 278);
            this.TbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(98, 20);
            this.TbEmail.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(59, 220);
            this.Surname.Margin = new System.Windows.Forms.Padding(2);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(98, 20);
            this.Surname.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Surname:";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(59, 169);
            this.TbName.Margin = new System.Windows.Forms.Padding(2);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(98, 20);
            this.TbName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            // 
            // TbPersonID
            // 
            this.TbPersonID.Location = new System.Drawing.Point(59, 109);
            this.TbPersonID.Margin = new System.Windows.Forms.Padding(2);
            this.TbPersonID.Name = "TbPersonID";
            this.TbPersonID.Size = new System.Drawing.Size(98, 20);
            this.TbPersonID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "PersonID:";
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.DgvUserCrud);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbPhonenumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbPersonID);
            this.Controls.Add(this.label1);
            this.Name = "PersonForm";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserCrud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUserCrud;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TbPhonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPersonID;
        private System.Windows.Forms.Label label1;
    }
}