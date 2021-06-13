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
    public partial class AdminMainFrm : Form
    {
        public AdminMainFrm()
        {
            InitializeComponent();
        }

        private void tsmLoan_Click(object sender, EventArgs e)
        {
            BookLoansFrm form = new();
            form.MdiParent = this;

            form.Show();
        }

        private void AdminMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BUsers.SignOut();
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUsers.SignOut();

            SignInFrm form = new();

            form.Show();
            this.Hide();
        }


        private void tsmManagement_Click(object sender, EventArgs e)
        {
            CrudBooks form = new();
            form.MdiParent = this;

            form.Show();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
