
namespace FV.View
{
    partial class CrudBooks
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
            System.Windows.Forms.Button Delete;
            this.bookgv = new System.Windows.Forms.DataGridView();
            this.createBook = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            Delete.Location = new System.Drawing.Point(649, 388);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(139, 50);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // bookgv
            // 
            this.bookgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookgv.Location = new System.Drawing.Point(12, 12);
            this.bookgv.Name = "bookgv";
            this.bookgv.RowTemplate.Height = 25;
            this.bookgv.Size = new System.Drawing.Size(776, 344);
            this.bookgv.TabIndex = 0;
            this.bookgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // createBook
            // 
            this.createBook.Location = new System.Drawing.Point(12, 388);
            this.createBook.Name = "createBook";
            this.createBook.Size = new System.Drawing.Size(140, 50);
            this.createBook.TabIndex = 1;
            this.createBook.Text = "Insertar Nuevo Libro";
            this.createBook.UseVisualStyleBackColor = true;
            this.createBook.Click += new System.EventHandler(this.createBook_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(322, 388);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(139, 50);
            this.Update.TabIndex = 2;
            this.Update.Text = "Actualizar";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // CrudBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.createBook);
            this.Controls.Add(this.bookgv);
            this.Name = "CrudBooks";
            this.Text = "CrudBooksFrm";
            this.Load += new System.EventHandler(this.CrudBooksFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookgv;
        private System.Windows.Forms.Button createBook;
        private System.Windows.Forms.Button Update;
    }
}