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


            //evitar que sea editable el GridView
            Devolutiongridview.ReadOnly = true;
            Devolutiongridview.DataSource = BLoans.listall();
            
        }

        
        




        private void Devolution_Click(object sender, EventArgs e)
        {

            if (Devolutiongridview.SelectedRows[0].Cells[0].Value.ToString() != null)
            {

                int loanid = Convert.ToInt32(Devolutiongridview.SelectedRows[0].Cells[0].Value);
                int copies = Convert.ToInt32(Devolutiongridview.SelectedRows[0].Cells[3].Value);
                string res= BLoans.Devolution(loanid, copies);



                MessageBox.Show(loanid.ToString() + copies.ToString());
                refreshdata();


            }
            else
            {
                MessageBox.Show("seleccione una linea completa!!");
            }
        }


    }
}
