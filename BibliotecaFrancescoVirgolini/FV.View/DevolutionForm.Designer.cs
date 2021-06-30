
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TeacherNametext = new System.Windows.Forms.Label();
            this.txtTeachers = new System.Windows.Forms.TextBox();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // Devolution
            // 
            this.Devolution.Location = new System.Drawing.Point(614, 522);
            this.Devolution.Name = "Devolution";
            this.Devolution.Size = new System.Drawing.Size(240, 70);
            this.Devolution.TabIndex = 1;
            this.Devolution.Text = "Libro Devuelto";
            this.Devolution.UseVisualStyleBackColor = true;
            this.Devolution.Click += new System.EventHandler(this.Devolution_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TeacherNametext);
            this.groupBox1.Controls.Add(this.txtTeachers);
            this.groupBox1.Controls.Add(this.btnTeachers);
            this.groupBox1.Controls.Add(this.dgvTeachers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por profesores";
            // 
            // TeacherNametext
            // 
            this.TeacherNametext.AutoSize = true;
            this.TeacherNametext.Location = new System.Drawing.Point(9, 30);
            this.TeacherNametext.Name = "TeacherNametext";
            this.TeacherNametext.Size = new System.Drawing.Size(117, 15);
            this.TeacherNametext.TabIndex = 3;
            this.TeacherNametext.Text = "Nombre del profesor";
            // 
            // txtTeachers
            // 
            this.txtTeachers.Location = new System.Drawing.Point(9, 51);
            this.txtTeachers.Name = "txtTeachers";
            this.txtTeachers.Size = new System.Drawing.Size(469, 23);
            this.txtTeachers.TabIndex = 2;
            this.txtTeachers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Location = new System.Drawing.Point(484, 50);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(75, 23);
            this.btnTeachers.TabIndex = 1;
            this.btnTeachers.Text = "Buscar";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.searchTeacherBtn_Click);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(6, 80);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowTemplate.Height = 25;
            this.dgvTeachers.Size = new System.Drawing.Size(560, 181);
            this.dgvTeachers.TabIndex = 0;
            this.dgvTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLoans);
            this.groupBox2.Location = new System.Drawing.Point(12, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 286);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prestamos Activos";
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(6, 22);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowTemplate.Height = 25;
            this.dgvLoans.Size = new System.Drawing.Size(560, 247);
            this.dgvLoans.TabIndex = 0;
            // 
            // DevolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Devolution);
            this.Name = "DevolutionForm";
            this.Text = "Devoluciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Devolution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Label TeacherNametext;
        private System.Windows.Forms.TextBox txtTeachers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLoans;
    }
}