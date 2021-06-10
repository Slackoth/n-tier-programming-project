
namespace FV.View
{
    partial class AdminMainFrm
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
            this.msLibrary = new System.Windows.Forms.MenuStrip();
            this.tsmBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReturns = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFrancesco = new System.Windows.Forms.ToolStripMenuItem();
            this.ssDeveloper = new System.Windows.Forms.StatusStrip();
            this.tsslblDevelopers = new System.Windows.Forms.ToolStripStatusLabel();
            this.msLibrary.SuspendLayout();
            this.ssDeveloper.SuspendLayout();
            this.SuspendLayout();
            // 
            // msLibrary
            // 
            this.msLibrary.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBooks,
            this.tsmLibrary,
            this.tsmFrancesco});
            this.msLibrary.Location = new System.Drawing.Point(0, 0);
            this.msLibrary.Name = "msLibrary";
            this.msLibrary.Size = new System.Drawing.Size(800, 28);
            this.msLibrary.TabIndex = 0;
            this.msLibrary.Text = "Libreria";
            // 
            // tsmBooks
            // 
            this.tsmBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManagement});
            this.tsmBooks.Name = "tsmBooks";
            this.tsmBooks.Size = new System.Drawing.Size(63, 24);
            this.tsmBooks.Text = "&Libros";
            // 
            // tsmManagement
            // 
            this.tsmManagement.Name = "tsmManagement";
            this.tsmManagement.Size = new System.Drawing.Size(193, 26);
            this.tsmManagement.Text = "Mantenimiento";
            // 
            // tsmLibrary
            // 
            this.tsmLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLoan,
            this.tsmReturns});
            this.tsmLibrary.Name = "tsmLibrary";
            this.tsmLibrary.Size = new System.Drawing.Size(90, 24);
            this.tsmLibrary.Text = "&Biblioteca";
            // 
            // tsmLoan
            // 
            this.tsmLoan.Name = "tsmLoan";
            this.tsmLoan.Size = new System.Drawing.Size(181, 26);
            this.tsmLoan.Text = "Préstamos";
            // 
            // tsmReturns
            // 
            this.tsmReturns.Name = "tsmReturns";
            this.tsmReturns.Size = new System.Drawing.Size(181, 26);
            this.tsmReturns.Text = "Devoluciones";
            // 
            // tsmFrancesco
            // 
            this.tsmFrancesco.Name = "tsmFrancesco";
            this.tsmFrancesco.Size = new System.Drawing.Size(148, 24);
            this.tsmFrancesco.Text = "&Francesco Virgolini";
            // 
            // ssDeveloper
            // 
            this.ssDeveloper.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssDeveloper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDevelopers});
            this.ssDeveloper.Location = new System.Drawing.Point(0, 424);
            this.ssDeveloper.Name = "ssDeveloper";
            this.ssDeveloper.Size = new System.Drawing.Size(800, 26);
            this.ssDeveloper.TabIndex = 1;
            this.ssDeveloper.Text = "Desarrolladores";
            // 
            // tsslblDevelopers
            // 
            this.tsslblDevelopers.Name = "tsslblDevelopers";
            this.tsslblDevelopers.Size = new System.Drawing.Size(331, 20);
            this.tsslblDevelopers.Text = "Desarrollado por Luis Calderón - Rene Meléndez";
            // 
            // AdminMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssDeveloper);
            this.Controls.Add(this.msLibrary);
            this.MainMenuStrip = this.msLibrary;
            this.Name = "AdminMainFrm";
            this.ShowIcon = false;
            this.Text = "Biblioteca Francesco Virgolini";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msLibrary.ResumeLayout(false);
            this.msLibrary.PerformLayout();
            this.ssDeveloper.ResumeLayout(false);
            this.ssDeveloper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msLibrary;
        private System.Windows.Forms.ToolStripMenuItem tsmBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmLibrary;
        private System.Windows.Forms.ToolStripMenuItem tsmLoan;
        private System.Windows.Forms.ToolStripMenuItem tsmReturns;
        private System.Windows.Forms.ToolStripMenuItem tsmFrancesco;
        private System.Windows.Forms.StatusStrip ssDeveloper;
        private System.Windows.Forms.ToolStripStatusLabel tsslblDevelopers;
    }
}