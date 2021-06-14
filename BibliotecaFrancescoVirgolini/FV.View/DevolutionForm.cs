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
        }

        private void refreshdata()
        {


            //evitar que sea editable el GridView

            Loangridview.ReadOnly = true;
         


        }


        private void Devolution_Click(object sender, EventArgs e)
        {

        }


    }
}
