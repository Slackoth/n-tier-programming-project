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

        private void BookLoansFrm_Load(object sender, EventArgs e)
        {
            ListBooks();
            ListTeachers();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            SearchTeachers();
        }
    }
}
