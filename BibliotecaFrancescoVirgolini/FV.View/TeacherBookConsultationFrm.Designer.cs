
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tsBook = new System.Windows.Forms.ToolStrip();
            this.tsbSignOut = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbBook.SuspendLayout();
            this.tsBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.dataGridView1);
            this.gbBook.Controls.Add(this.btnSearch);
            this.gbBook.Controls.Add(this.comboBox1);
            this.gbBook.Controls.Add(this.textBox1);
            this.gbBook.Controls.Add(this.lblFilter);
            this.gbBook.Controls.Add(this.lblSearch);
            this.gbBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBook.Location = new System.Drawing.Point(12, 30);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(858, 511);
            this.gbBook.TabIndex = 0;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Consulta de libros";
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
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(406, 38);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(43, 20);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filtro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 27);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(407, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(603, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tsBook
            // 
            this.tsBook.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSignOut});
            this.tsBook.Location = new System.Drawing.Point(0, 0);
            this.tsBook.Name = "tsBook";
            this.tsBook.Size = new System.Drawing.Size(882, 27);
            this.tsBook.TabIndex = 1;
            this.tsBook.Text = "toolStrip1";
            // 
            // tsbSignOut
            // 
            this.tsbSignOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSignOut.Image = global::FV.View.Properties.Resources.exit;
            this.tsbSignOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSignOut.Name = "tsbSignOut";
            this.tsbSignOut.Size = new System.Drawing.Size(29, 24);
            this.tsbSignOut.Text = "Cerrar Sesión";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(846, 411);
            this.dataGridView1.TabIndex = 5;
            // 
            // TeacherBookConsultationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.tsBook);
            this.Controls.Add(this.gbBook);
            this.Name = "TeacherBookConsultationFrm";
            this.ShowIcon = false;
            this.Text = "Consulta de Libros";
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.tsBook.ResumeLayout(false);
            this.tsBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolStrip tsBook;
        private System.Windows.Forms.ToolStripButton tsbSignOut;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}