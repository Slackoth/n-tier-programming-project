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
    public partial class SignInFrm : Form
    {
        public SignInFrm()
        {
            InitializeComponent();
        }

        private void SignInFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool found = false;
            string email = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (AreFieldsValid(email, password))
            {
                ErrorMessage("Cambos obligatorios deben de ser llenados.");
                return;
            }

            try
            {
                found = BUsers.SignIn(email, password);
            }
            catch (Exception)
            {
                throw;
            }

            if (found)
            {
                DisplayAdminOrTeacherForm();
            }
            else
            {
                ErrorMessage("Usuario no encontrado.");
                return;
            }

        }

        private bool AreFieldsValid(string email, string password)
        {
            bool invalid = false;

            if (email == string.Empty)
            {
                invalid = true;
                epSignIn.SetError(txtUser, "Digite su correo.");
            }

            if (password == string.Empty)
            {
                invalid = true;
                epSignIn.SetError(txtPassword, "Digite su clave.");
            }

            return invalid;
        }

        private void DisplayAdminOrTeacherForm()
        {
            if(BUsers.GetUserSessionRole())
            {
                AdminMainFrm admin = new AdminMainFrm();
                admin.Show();
            }
            else
            {
                TeacherBookConsultationFrm teacher = new TeacherBookConsultationFrm();
                teacher.Show();
            }

            this.Hide();
        }
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Biblioteca Francesco Virgolini", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SignInFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
