
namespace FV.View
{
    partial class TeacherBookConsultationFrm
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
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tsbSignOut = new System.Windows.Forms.ToolStripButton();
            this.tsBook = new System.Windows.Forms.ToolStrip();
            this.gbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tsBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.dgvBooks);
            this.gbBook.Controls.Add(this.btnSearch);
            this.gbBook.Controls.Add(this.cbFilter);
            this.gbBook.Controls.Add(this.txtBooks);
            this.gbBook.Controls.Add(this.lblFilter);
            this.gbBook.Controls.Add(this.lblSearch);
            this.gbBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBook.Location = new System.Drawing.Point(12, 30);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(1513, 511);
            this.gbBook.TabIndex = 0;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Consulta de libros";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(6, 94);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 29;
            this.dgvBooks.Size = new System.Drawing.Size(1505, 411);
            this.dgvBooks.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(758, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "Editorial",
            "País",
            "Lenguaje",
            "Género"});
            this.cbFilter.Location = new System.Drawing.Point(562, 57);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(190, 28);
            this.cbFilter.TabIndex = 3;
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(6, 61);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(395, 27);
            this.txtBooks.TabIndex = 2;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(562, 34);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(58, 20);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Criterio";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 38);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(201, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Frase o palabra de búsqueda";
            // 
            // tsbSignOut
            // 
            this.tsbSignOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSignOut.Image = global::FV.View.Properties.Resources.exit;
            this.tsbSignOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSignOut.Name = "tsbSignOut";
            this.tsbSignOut.Size = new System.Drawing.Size(29, 24);
            this.tsbSignOut.Text = "Cerrar Sesión";
            this.tsbSignOut.Click += new System.EventHandler(this.tsbSignOut_Click);
            // 
            // tsBook
            // 
            this.tsBook.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSignOut});
            this.tsBook.Location = new System.Drawing.Point(0, 0);
            this.tsBook.Name = "tsBook";
            this.tsBook.Size = new System.Drawing.Size(1537, 27);
            this.tsBook.TabIndex = 1;
            this.tsBook.Text = "toolStrip1";
            // 
            // TeacherBookConsultationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 553);
            this.Controls.Add(this.tsBook);
            this.Controls.Add(this.gbBook);
            this.Name = "TeacherBookConsultationFrm";
            this.ShowIcon = false;
            this.Text = "Consulta de Libros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherBookConsultationFrm_FormClosing);
            this.Load += new System.EventHandler(this.TeacherBookConsultationFrm_Load);
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tsBook.ResumeLayout(false);
            this.tsBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ToolStripButton tsbSignOut;
        private System.Windows.Forms.ToolStrip tsBook;
    }
}