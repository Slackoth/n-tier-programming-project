
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
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmFrancesco,
            this.cerrarSesiónToolStripMenuItem});
            this.msLibrary.Location = new System.Drawing.Point(0, 0);
            this.msLibrary.Name = "msLibrary";
            this.msLibrary.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msLibrary.Size = new System.Drawing.Size(700, 24);
            this.msLibrary.TabIndex = 0;
            this.msLibrary.Text = "Libreria";
            // 
            // tsmBooks
            // 
            this.tsmBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManagement});
            this.tsmBooks.Name = "tsmBooks";
            this.tsmBooks.Size = new System.Drawing.Size(51, 20);
            this.tsmBooks.Text = "&Libros";
            // 
            // tsmManagement
            // 
            this.tsmManagement.Name = "tsmManagement";
            this.tsmManagement.Size = new System.Drawing.Size(180, 22);
            this.tsmManagement.Text = "Mantenimiento";
            this.tsmManagement.Click += new System.EventHandler(this.tsmManagement_Click);
            // 
            // tsmLibrary
            // 
            this.tsmLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLoan,
            this.tsmReturns});
            this.tsmLibrary.Name = "tsmLibrary";
            this.tsmLibrary.Size = new System.Drawing.Size(71, 20);
            this.tsmLibrary.Text = "&Biblioteca";
            // 
            // tsmLoan
            // 
            this.tsmLoan.Name = "tsmLoan";
            this.tsmLoan.Size = new System.Drawing.Size(145, 22);
            this.tsmLoan.Text = "Préstamos";
            this.tsmLoan.Click += new System.EventHandler(this.tsmLoan_Click);
            // 
            // tsmReturns
            // 
            this.tsmReturns.Name = "tsmReturns";
            this.tsmReturns.Size = new System.Drawing.Size(145, 22);
            this.tsmReturns.Text = "Devoluciones";
            // 
            // tsmFrancesco
            // 
            this.tsmFrancesco.Name = "tsmFrancesco";
            this.tsmFrancesco.Size = new System.Drawing.Size(119, 20);
            this.tsmFrancesco.Text = "&Francesco Virgolini";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "&Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // ssDeveloper
            // 
            this.ssDeveloper.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssDeveloper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblDevelopers});
            this.ssDeveloper.Location = new System.Drawing.Point(0, 316);
            this.ssDeveloper.Name = "ssDeveloper";
            this.ssDeveloper.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.ssDeveloper.Size = new System.Drawing.Size(700, 22);
            this.ssDeveloper.TabIndex = 1;
            this.ssDeveloper.Text = "Desarrolladores";
            // 
            // tsslblDevelopers
            // 
            this.tsslblDevelopers.Name = "tsslblDevelopers";
            this.tsslblDevelopers.Size = new System.Drawing.Size(260, 17);
            this.tsslblDevelopers.Text = "Desarrollado por Luis Calderón - Rene Meléndez";
            // 
            // AdminMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.ssDeveloper);
            this.Controls.Add(this.msLibrary);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msLibrary;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Francesco Virgolini";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMainFrm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}