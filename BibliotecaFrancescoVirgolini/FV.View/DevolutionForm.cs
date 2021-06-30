using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FV.Business;

namespace FV.View
{
    public partial class DevolutionForm : Form
    {
        public DevolutionForm()
        {
            InitializeComponent();
            refreshdata();
        }

        private void refreshdata()
        {
            ListTeachers();
           

        }
        private void DgvLoansFormat()
        {
            dgvLoans.Columns[0].Visible = false;
            dgvLoans.Columns[1].HeaderText = "Libro";
            dgvLoans.Columns[2].HeaderText = "Fecha de préstamo";
            dgvLoans.Columns[3].HeaderText = "Fecha de devolución";

            for (int i = 1; i < 4; i++)
            {
                dgvLoans.Columns[i].Width = 230;
            }
        }

        private void ListTeachers()
        {
            try
            {
                dgvTeachers.DataSource = BUsers.ListTeachers();

                DgvTeachersFormat();
                txtTeachers.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        private void ApplyLoanList(bool flag = false)
        {
            int id = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells[0].Value);


            if (flag)
                id = 0;
            else
                ListLoans(id);
        }
        private void ListLoans(int id)
        {
            try
            {
                dgvLoans.DataSource = BLoans.List(id);

                DgvLoansFormat();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvTeachers.Rows[e.RowIndex].Cells[0].Value);
                ListLoans(id);

            }
            catch (Exception) { }
        }


        private void DgvTeachersFormat()
        {
            dgvTeachers.Columns[0].Visible = false;
            dgvTeachers.Columns[1].HeaderText = "Nombres";
            dgvTeachers.Columns[2].HeaderText = "Apellidos";
            dgvTeachers.Columns[3].HeaderText = "Correo";

            for (int i = 1; i < 4; i++)
            {
                dgvTeachers.Columns[i].Width = 210;
            }
        }
        private void SearchTeachers()
        {
            string value = txtTeachers.Text;

            try
            {
                dgvTeachers.DataSource = BUsers.SearchTeachers(value);

                DgvTeachersFormat();
                txtTeachers.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        
        private void Devolution_Click(object sender, EventArgs e)
        {
            
            try {
                int id = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells[0].Value);
                int loanid = Convert.ToInt32(dgvLoans.SelectedRows[0].Cells[0].Value);
                int copies = Convert.ToInt32(dgvLoans.SelectedRows[0].Cells[1].Value);
                //MessageBox.Show(loanid.ToString());
                //MessageBox.Show(copies.ToString());
                string res= BLoans.Devolution(loanid, copies);
                ListLoans(id);



                MessageBox.Show("se ha devuelto con exito");
                refreshdata();


            }
           catch(Exception ex)
            {
                MessageBox.Show("seleccione una linea completa!!");
            }
        }

        private void Devolutiongridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTeacherBtn_Click(object sender, EventArgs e)
        {
            SearchTeachers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
