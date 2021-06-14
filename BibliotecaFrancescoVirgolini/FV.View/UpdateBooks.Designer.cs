
namespace FV.View
{
    partial class UpdateBooks
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

        private void InitializeComponent()
        {
            this.booktitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.bookisbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookquantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boookedition = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bookubication = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookpages = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.bookdesc = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EditorialList = new System.Windows.Forms.ComboBox();
            this.LanguageList = new System.Windows.Forms.ComboBox();
            this.countrieList = new System.Windows.Forms.ComboBox();
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AuthorList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boookedition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookpages)).BeginInit();
            this.SuspendLayout();
            // 
            // booktitle
            // 
            this.booktitle.Location = new System.Drawing.Point(118, 20);
            this.booktitle.Name = "booktitle";
            this.booktitle.Size = new System.Drawing.Size(628, 23);
            this.booktitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo del Libro";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(621, 374);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(123, 49);
            this.Update.TabIndex = 2;
            this.Update.Text = "Actualizar";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookisbn
            // 
            this.bookisbn.Location = new System.Drawing.Point(118, 66);
            this.bookisbn.Name = "bookisbn";
            this.bookisbn.Size = new System.Drawing.Size(247, 23);
            this.bookisbn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN";
            // 
            // bookquantity
            // 
            this.bookquantity.Location = new System.Drawing.Point(442, 66);
            this.bookquantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bookquantity.Name = "bookquantity";
            this.bookquantity.Size = new System.Drawing.Size(114, 23);
            this.bookquantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edición";
            // 
            // boookedition
            // 
            this.boookedition.Location = new System.Drawing.Point(624, 65);
            this.boookedition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.boookedition.Name = "boookedition";
            this.boookedition.Size = new System.Drawing.Size(120, 23);
            this.boookedition.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ubicación";
            // 
            // bookubication
            // 
            this.bookubication.Location = new System.Drawing.Point(118, 117);
            this.bookubication.Name = "bookubication";
            this.bookubication.Size = new System.Drawing.Size(318, 23);
            this.bookubication.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Número de Páginas";
            // 
            // bookpages
            // 
            this.bookpages.Location = new System.Drawing.Point(561, 120);
            this.bookpages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.bookpages.Name = "bookpages";
            this.bookpages.Size = new System.Drawing.Size(183, 23);
            this.bookpages.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripción";
            // 
            // bookdesc
            // 
            this.bookdesc.Location = new System.Drawing.Point(127, 178);
            this.bookdesc.Name = "bookdesc";
            this.bookdesc.Size = new System.Drawing.Size(617, 77);
            this.bookdesc.TabIndex = 15;
            this.bookdesc.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Editorial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Pais de Origen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Idioma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tematica";
            // 
            // EditorialList
            // 
            this.EditorialList.FormattingEnabled = true;
            this.EditorialList.Location = new System.Drawing.Point(118, 270);
            this.EditorialList.Name = "EditorialList";
            this.EditorialList.Size = new System.Drawing.Size(121, 23);
            this.EditorialList.TabIndex = 20;
            // 
            // LanguageList
            // 
            this.LanguageList.FormattingEnabled = true;
            this.LanguageList.Location = new System.Drawing.Point(351, 270);
            this.LanguageList.Name = "LanguageList";
            this.LanguageList.Size = new System.Drawing.Size(121, 23);
            this.LanguageList.TabIndex = 21;
            // 
            // countrieList
            // 
            this.countrieList.FormattingEnabled = true;
            this.countrieList.Location = new System.Drawing.Point(623, 273);
            this.countrieList.Name = "countrieList";
            this.countrieList.Size = new System.Drawing.Size(121, 23);
            this.countrieList.TabIndex = 22;
            // 
            // SubjectList
            // 
            this.SubjectList.FormattingEnabled = true;
            this.SubjectList.Location = new System.Drawing.Point(118, 352);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(121, 23);
            this.SubjectList.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Autor";
            // 
            // AuthorList
            // 
            this.AuthorList.AccessibleDescription = "AuthorList";
            this.AuthorList.FormattingEnabled = true;
            this.AuthorList.Location = new System.Drawing.Point(351, 352);
            this.AuthorList.Name = "AuthorList";
            this.AuthorList.Size = new System.Drawing.Size(121, 23);
            this.AuthorList.TabIndex = 25;
            // 
            // UpdateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AuthorList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SubjectList);
            this.Controls.Add(this.countrieList);
            this.Controls.Add(this.LanguageList);
            this.Controls.Add(this.EditorialList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bookdesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bookpages);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bookubication);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boookedition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookquantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookisbn);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booktitle);
            this.Name = "UpdateBooks";
            this.Text = "Actualizar Datos";
            this.Load += new System.EventHandler(this.UpdateBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boookedition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookpages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.TextBox booktitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bookisbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bookquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown boookedition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown bookpages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox bookdesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox EditorialList;
        private System.Windows.Forms.ComboBox LanguageList;
        private System.Windows.Forms.ComboBox countrieList;
        private System.Windows.Forms.ComboBox SubjectList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox AuthorList;
        private System.Windows.Forms.TextBox bookubication;
        private System.Windows.Forms.Button Update;
    }
}
    
