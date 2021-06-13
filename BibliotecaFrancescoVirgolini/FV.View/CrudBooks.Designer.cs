
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
            this.bookgv = new System.Windows.Forms.DataGridView();
            this.createBook = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bookgv
            // 
            this.bookgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookgv.Location = new System.Drawing.Point(12, 12);
            this.bookgv.Name = "bookgv";
            this.bookgv.RowTemplate.Height = 25;
            this.bookgv.Size = new System.Drawing.Size(776, 289);
            this.bookgv.TabIndex = 0;
            this.bookgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // createBook
            // 
            this.createBook.Location = new System.Drawing.Point(12, 319);
            this.createBook.Name = "createBook";
            this.createBook.Size = new System.Drawing.Size(140, 50);
            this.createBook.TabIndex = 1;
            this.createBook.Text = "Insertar Nuevo Libro";
            this.createBook.UseVisualStyleBackColor = true;
            this.createBook.Click += new System.EventHandler(this.createBook_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // CrudBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}