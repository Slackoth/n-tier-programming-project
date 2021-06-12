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
    public partial class TeacherBookConsultationFrm : Form
    {
        public TeacherBookConsultationFrm()
        {
            InitializeComponent();
        }

        private void List()
        {
            try
            {
                dgvBooks.DataSource = BBooks.List();

                DgvFormat();
                Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void Search()
        {
            string value = txtBooks.Text;
            int type = cbFilter.SelectedIndex;

            try
            {
                dgvBooks.DataSource = BBooks.Search(value, type);

                DgvFormat();
                Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        private void DgvFormat()
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

        private void Clear()
        {
            txtBooks.Clear();
            cbFilter.SelectedIndex = 0;
        }

        private void TeacherBookConsultationFrm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void TeacherBookConsultationFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BUsers.SignOut();
            Application.Exit();
        }

        private void tsbSignOut_Click(object sender, EventArgs e)
        {
            BUsers.SignOut();
            
            SignInFrm form = new SignInFrm();

            form.Show();
            this.Hide();

        }
    }
}
