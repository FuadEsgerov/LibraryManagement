namespace Library.Forms
{
    partial class BookStore
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
            this.BtnReturnBooks = new System.Windows.Forms.Button();
            this.DgvCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Your = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvSearchResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookSearchBoxTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReturnBooks
            // 
            this.BtnReturnBooks.Location = new System.Drawing.Point(639, 143);
            this.BtnReturnBooks.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReturnBooks.Name = "BtnReturnBooks";
            this.BtnReturnBooks.Size = new System.Drawing.Size(91, 47);
            this.BtnReturnBooks.TabIndex = 24;
            this.BtnReturnBooks.Text = "ReturnBooks";
            this.BtnReturnBooks.UseVisualStyleBackColor = true;
            // 
            // DgvCart
            // 
            this.DgvCart.AllowUserToAddRows = false;
            this.DgvCart.AllowUserToDeleteRows = false;
            this.DgvCart.AllowUserToResizeColumns = false;
            this.DgvCart.AllowUserToResizeRows = false;
            this.DgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4});
            this.DgvCart.Location = new System.Drawing.Point(276, 333);
            this.DgvCart.Margin = new System.Windows.Forms.Padding(2);
            this.DgvCart.Name = "DgvCart";
            this.DgvCart.RowHeadersWidth = 51;
            this.DgvCart.RowTemplate.Height = 24;
            this.DgvCart.Size = new System.Drawing.Size(286, 138);
            this.DgvCart.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "bookID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Your
            // 
            this.Your.AutoSize = true;
            this.Your.Location = new System.Drawing.Point(274, 309);
            this.Your.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Your.Name = "Your";
            this.Your.Size = new System.Drawing.Size(60, 13);
            this.Your.TabIndex = 21;
            this.Your.Text = "Your Items:";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(115, 419);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(82, 27);
            this.BtnConfirm.TabIndex = 20;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(115, 155);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(103, 29);
            this.BtnSearch.TabIndex = 19;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Location = new System.Drawing.Point(113, 347);
            this.returnDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(65, 13);
            this.returnDateLabel.TabIndex = 18;
            this.returnDateLabel.Text = "Return Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 377);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book:";
            // 
            // DgvSearchResult
            // 
            this.DgvSearchResult.AllowUserToAddRows = false;
            this.DgvSearchResult.AllowUserToDeleteRows = false;
            this.DgvSearchResult.AllowUserToResizeColumns = false;
            this.DgvSearchResult.AllowUserToResizeRows = false;
            this.DgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvSearchResult.Location = new System.Drawing.Point(276, 88);
            this.DgvSearchResult.Margin = new System.Windows.Forms.Padding(2);
            this.DgvSearchResult.Name = "DgvSearchResult";
            this.DgvSearchResult.RowHeadersWidth = 51;
            this.DgvSearchResult.RowTemplate.Height = 24;
            this.DgvSearchResult.Size = new System.Drawing.Size(286, 189);
            this.DgvSearchResult.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.HeaderText = "bookID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Genre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // BookSearchBoxTB
            // 
            this.BookSearchBoxTB.Location = new System.Drawing.Point(115, 120);
            this.BookSearchBoxTB.Margin = new System.Windows.Forms.Padding(2);
            this.BookSearchBoxTB.Name = "BookSearchBoxTB";
            this.BookSearchBoxTB.Size = new System.Drawing.Size(133, 20);
            this.BookSearchBoxTB.TabIndex = 14;
            // 
            // BookStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 506);
            this.Controls.Add(this.BtnReturnBooks);
            this.Controls.Add(this.DgvCart);
            this.Controls.Add(this.Your);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvSearchResult);
            this.Controls.Add(this.BookSearchBoxTB);
            this.Name = "BookStore";
            this.Text = "BookStore";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReturnBooks;
        private System.Windows.Forms.DataGridView DgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label Your;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox BookSearchBoxTB;
    }
}