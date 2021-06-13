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
    public partial class BookLoansFrm : Form
    {
        public BookLoansFrm()
        {
            InitializeComponent();
        }

        private void ListBooks()
        {
            try
            {
                dgvBooks.DataSource = BBooks.List();

                DgvBooksFormat();
                ClearBooks();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void SearchBooks()
        {
            string value = txtBooks.Text;
            int type = cbBooks.SelectedIndex;

            try
            {
                dgvBooks.DataSource = BBooks.Search(value, type);

                DgvBooksFormat();
                ClearBooks();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void DgvBooksFormat()
        {
            dgvBooks.Columns[0].Visible = false;
            dgvBooks.Columns[1].HeaderText = "Título";
            dgvBooks.Columns[2].HeaderText = "Autor";
            dgvBooks.Columns[3].HeaderText = "Editorial";
            dgvBooks.Columns[4].HeaderText = "País";
            dgvBooks.Columns[5].HeaderText = "Lenguaje";
            dgvBooks.Columns[6].HeaderText = "Género";
            dgvBooks.Columns[7].HeaderText = "Ubicación";

            for (int i = 1; i < 8; i++)
            {
                dgvBooks.Columns[i].Width = 210;
            }
        }

        private void ClearBooks()
        {
            txtBooks.Clear();
            cbBooks.SelectedIndex = 0;
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

        private void SearchLoans(int id)
        {
            DateTime date = dtpReturn.Value.Date;

            try
            {
                dgvLoans.DataSource = BLoans.Search(id, date);

                DgvLoansFormat();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
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

        private void BookLoansFrm_Load(object sender, EventArgs e)
        {
            ListBooks();
            ListTeachers();
            ApplyLoanList();

            dtpReturn.Format = DateTimePickerFormat.Custom;
            dtpReturn.CustomFormat = "yyyy-MM-dd";
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            SearchTeachers();
        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvTeachers.Rows[e.RowIndex].Cells[0].Value);
                ListLoans(id);
                
            }
            catch (Exception) {}
        }

        private void btnRegisterLoan_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value);
            int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells[0].Value);
            DateTime loanDate = DateTime.Now.Date;
            DateTime returnDate = loanDate.AddDays(7).Date;

            string message = InsertLoan(bookId, teacherId, loanDate, returnDate);

            ListLoans(teacherId);
            InfoMessage(message);
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            ApplyLoanList(true);
        }

        private void ApplyLoanList(bool flag = false)
        {
            int id = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells[0].Value);

            if (flag)
                SearchLoans(id);
            else
                ListLoans(id);
        }

        private string InsertLoan(int bookId, int teacherId, DateTime loanDate, DateTime returnDate)
        {
            return BLoans.Insert(bookId, teacherId, loanDate, returnDate);
        }

        private void InfoMessage(string message)
        {
            MessageBox.Show(message, "Biblioteca Francesco Virgolini", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
