
namespace FV.View
{
    partial class BookLoansFrm
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
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.btnBooks = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.gbTeachers = new System.Windows.Forms.GroupBox();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.txtTeachers = new System.Windows.Forms.TextBox();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.gbLoan = new System.Windows.Forms.GroupBox();
            this.btnLoans = new System.Windows.Forms.Button();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.btnRegisterLoan = new System.Windows.Forms.Button();
            this.gbBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.gbTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.gbLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBooks
            // 
            this.gbBooks.Controls.Add(this.btnBooks);
            this.gbBooks.Controls.Add(this.dgvBooks);
            this.gbBooks.Controls.Add(this.txtBooks);
            this.gbBooks.Controls.Add(this.cbBooks);
            this.gbBooks.Controls.Add(this.lblFilter);
            this.gbBooks.Controls.Add(this.lblBooks);
            this.gbBooks.Location = new System.Drawing.Point(10, 9);
            this.gbBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBooks.Size = new System.Drawing.Size(612, 300);
            this.gbBooks.TabIndex = 0;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "Búsqueda de libros";
            this.gbBooks.Enter += new System.EventHandler(this.gbBooks_Enter);
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(525, 33);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(82, 22);
            this.btnBooks.TabIndex = 7;
            this.btnBooks.Text = "Buscar";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(10, 59);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 29;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(597, 236);
            this.dgvBooks.TabIndex = 4;
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(10, 34);
            this.txtBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(312, 23);
            this.txtBooks.TabIndex = 3;
            // 
            // cbBooks
            // 
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "Editorial",
            "País",
            "Lenguaje",
            "Género"});
            this.cbBooks.Location = new System.Drawing.Point(327, 34);
            this.cbBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(193, 23);
            this.cbBooks.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(327, 16);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(46, 15);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Criterio";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(10, 17);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(157, 15);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "Frase o palabra de búsqueda";
            // 
            // gbTeachers
            // 
            this.gbTeachers.Controls.Add(this.btnTeachers);
            this.gbTeachers.Controls.Add(this.dgvTeachers);
            this.gbTeachers.Controls.Add(this.txtTeachers);
            this.gbTeachers.Controls.Add(this.lblTeachers);
            this.gbTeachers.Location = new System.Drawing.Point(630, 9);
            this.gbTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTeachers.Name = "gbTeachers";
            this.gbTeachers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTeachers.Size = new System.Drawing.Size(612, 300);
            this.gbTeachers.TabIndex = 1;
            this.gbTeachers.TabStop = false;
            this.gbTeachers.Text = "Búsqueda de docentes";
            // 
            // btnTeachers
            // 
            this.btnTeachers.Location = new System.Drawing.Point(404, 36);
            this.btnTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(82, 22);
            this.btnTeachers.TabIndex = 6;
            this.btnTeachers.Text = "Buscar";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            this.dgvTeachers.AllowUserToOrderColumns = true;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(5, 61);
            this.dgvTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.RowHeadersWidth = 51;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(602, 235);
            this.dgvTeachers.TabIndex = 5;
            this.dgvTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellClick);
            this.dgvTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellContentClick);
            // 
            // txtTeachers
            // 
            this.txtTeachers.Location = new System.Drawing.Point(5, 36);
            this.txtTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeachers.Name = "txtTeachers";
            this.txtTeachers.Size = new System.Drawing.Size(394, 23);
            this.txtTeachers.TabIndex = 4;
            // 
            // lblTeachers
            // 
            this.lblTeachers.AutoSize = true;
            this.lblTeachers.Location = new System.Drawing.Point(5, 17);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(171, 15);
            this.lblTeachers.TabIndex = 1;
            this.lblTeachers.Text = "Nombre o apellido del docente";
            // 
            // gbLoan
            // 
            this.gbLoan.Controls.Add(this.btnLoans);
            this.gbLoan.Controls.Add(this.dgvLoans);
            this.gbLoan.Controls.Add(this.dtpReturn);
            this.gbLoan.Controls.Add(this.lblReturnDate);
            this.gbLoan.Location = new System.Drawing.Point(16, 314);
            this.gbLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLoan.Name = "gbLoan";
            this.gbLoan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLoan.Size = new System.Drawing.Size(788, 257);
            this.gbLoan.TabIndex = 2;
            this.gbLoan.TabStop = false;
            this.gbLoan.Text = "Préstamos activos del docente";
            // 
            // btnLoans
            // 
            this.btnLoans.Location = new System.Drawing.Point(614, 62);
            this.btnLoans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(164, 22);
            this.btnLoans.TabIndex = 7;
            this.btnLoans.Text = "Buscar";
            this.btnLoans.UseVisualStyleBackColor = true;
            this.btnLoans.Click += new System.EventHandler(this.btnLoans_Click);
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AllowUserToOrderColumns = true;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(5, 20);
            this.dgvLoans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.RowHeadersWidth = 51;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(604, 233);
            this.dgvLoans.TabIndex = 6;
            // 
            // dtpReturn
            // 
            this.dtpReturn.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpReturn.CustomFormat = "";
            this.dtpReturn.Location = new System.Drawing.Point(614, 37);
            this.dtpReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpReturn.MaxDate = new System.DateTime(9010, 12, 31, 0, 0, 0, 0);
            this.dtpReturn.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(164, 23);
            this.dtpReturn.TabIndex = 4;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(614, 20);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(149, 15);
            this.lblReturnDate.TabIndex = 3;
            this.lblReturnDate.Text = "Fecha límite de devolución";
            // 
            // btnRegisterLoan
            // 
            this.btnRegisterLoan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterLoan.Location = new System.Drawing.Point(1024, 533);
            this.btnRegisterLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterLoan.Name = "btnRegisterLoan";
            this.btnRegisterLoan.Size = new System.Drawing.Size(219, 38);
            this.btnRegisterLoan.TabIndex = 7;
            this.btnRegisterLoan.Text = "Registrar Préstamo";
            this.btnRegisterLoan.UseVisualStyleBackColor = true;
            this.btnRegisterLoan.Click += new System.EventHandler(this.btnRegisterLoan_Click);
            // 
            // BookLoansFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 580);
            this.Controls.Add(this.btnRegisterLoan);
            this.Controls.Add(this.gbLoan);
            this.Controls.Add(this.gbTeachers);
            this.Controls.Add(this.gbBooks);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookLoansFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4";
            this.Load += new System.EventHandler(this.BookLoansFrm_Load);
            this.gbBooks.ResumeLayout(false);
            this.gbBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.gbTeachers.ResumeLayout(false);
            this.gbTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.gbLoan.ResumeLayout(false);
            this.gbLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBooks;
        private System.Windows.Forms.GroupBox gbTeachers;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.TextBox txtTeachers;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.GroupBox gbLoan;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Button btnRegisterLoan;
        private System.Windows.Forms.Button btnLoans;
    }
}