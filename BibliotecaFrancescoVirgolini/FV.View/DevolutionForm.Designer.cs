
namespace FV.View
{
    partial class DevolutionForm
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
            this.Devolution = new System.Windows.Forms.Button();
            this.Devolutiongridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Devolutiongridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Devolution
            // 
            this.Devolution.Location = new System.Drawing.Point(970, 453);
            this.Devolution.Name = "Devolution";
            this.Devolution.Size = new System.Drawing.Size(240, 70);
            this.Devolution.TabIndex = 1;
            this.Devolution.Text = "Libro Devuelto";
            this.Devolution.UseVisualStyleBackColor = true;
            this.Devolution.Click += new System.EventHandler(this.Devolution_Click);
            // 
            // Devolutiongridview
            // 
            this.Devolutiongridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Devolutiongridview.Location = new System.Drawing.Point(12, 12);
            this.Devolutiongridview.Name = "Devolutiongridview";
            this.Devolutiongridview.RowTemplate.Height = 25;
            this.Devolutiongridview.Size = new System.Drawing.Size(1198, 435);
            this.Devolutiongridview.TabIndex = 2;
            // 
            // DevolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 535);
            this.Controls.Add(this.Devolutiongridview);
            this.Controls.Add(this.Devolution);
            this.Name = "DevolutionForm";
            this.Text = "Devoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.Devolutiongridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Devolution;
        private System.Windows.Forms.DataGridView Devolutiongridview;
    }
}