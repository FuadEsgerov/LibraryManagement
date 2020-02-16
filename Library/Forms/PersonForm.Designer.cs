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
            this.components = new System.ComponentModel.Container();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgvUserCrud = new System.Windows.Forms.DataGridView();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Library.DataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.TbPersonID = new System.Windows.Forms.TextBox();
            this.peopleTableAdapter1 = new Library.DataSet1TableAdapters.PeopleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserCrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
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
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(59, 339);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(98, 20);
            this.TbPassword.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Password:\r\n";
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
            // TbSurname
            // 
            this.TbSurname.Location = new System.Drawing.Point(59, 220);
            this.TbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.TbSurname.Name = "TbSurname";
            this.TbSurname.Size = new System.Drawing.Size(98, 20);
            this.TbSurname.TabIndex = 19;
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
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(150, 421);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 37);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgvUserCrud
            // 
            this.DgvUserCrud.AllowUserToDeleteRows = false;
            this.DgvUserCrud.AutoGenerateColumns = false;
            this.DgvUserCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUserCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUserCrud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DgvUserCrud.DataSource = this.peopleBindingSource;
            this.DgvUserCrud.Location = new System.Drawing.Point(273, 85);
            this.DgvUserCrud.Margin = new System.Windows.Forms.Padding(2);
            this.DgvUserCrud.Name = "DgvUserCrud";
            this.DgvUserCrud.ReadOnly = true;
            this.DgvUserCrud.RowHeadersWidth = 51;
            this.DgvUserCrud.RowTemplate.Height = 24;
            this.DgvUserCrud.Size = new System.Drawing.Size(560, 373);
            this.DgvUserCrud.TabIndex = 28;
            this.DgvUserCrud.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUserCrud_RowHeaderMouseDoubleClick);
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "PersonID:";
            // 
            // TbPersonID
            // 
            this.TbPersonID.Location = new System.Drawing.Point(59, 112);
            this.TbPersonID.Margin = new System.Windows.Forms.Padding(2);
            this.TbPersonID.Name = "TbPersonID";
            this.TbPersonID.Size = new System.Drawing.Size(98, 20);
            this.TbPersonID.TabIndex = 15;
            // 
            // peopleTableAdapter1
            // 
            this.peopleTableAdapter1.ClearBeforeFill = true;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.DgvUserCrud);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbPersonID);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonForm";
            this.Text = "Person";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserCrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label2;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DgvUserCrud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbPersonID;
        private DataSet1TableAdapters.PeopleTableAdapter peopleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}